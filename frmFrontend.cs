using LabHotelManagment.Context;
using LabHotelManagment.Entities;
using LabHotelManagment.Managers;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LabHotelManagment
{
    public partial class frmFrontend : Form
    {
        HotelContext Context = new();
        BindingSource BSResv = new();
        BindingSource BSGuest = new();
        int CurrentRoomNo { set; get; }


        ReservationManager ResManager;
        RoomManager RoomMgr;
        List<Reservation> ReservationsList;
        List<Room> RoomList;


        public frmFrontend()
        {
            StartPosition = FormStartPosition.CenterScreen;
            this.FormClosed += (s, e) => Context.Dispose();

            //using Dapper
            ResManager = new();
            RoomMgr = new();
            QRefresh();

            InitializeComponent();
            FixDatePickerFormats();
            loadGridView();
            LoadReservationPage();
        }

        private void QRefresh()
        {
            ReservationsList = ResManager.GetAll();
            RoomList = RoomMgr.GetAll();
            foreach (var room in RoomList)
                room.Reservations = ReservationsList.Where(r => r.RoomNumber == room.RoomNumber).ToList();
        }

        private void LoadBindings()
        {
            BSResv.DataSource = ReservationsList;

            BSGuest.DataSource = BSResv;
            BSGuest.DataMember = "Guest";

            //bind with class ListDisplay for proper display
            lst_Reservations.DataSource = BSResv;

            //Simple data binding controls bind with nested BS
            txt_fname.DataBindings.Add("Text", BSGuest, "Fname");
            txt_lname.DataBindings.Add("Text", BSGuest, "Lname");
            txt_pno.DataBindings.Add("Text", BSGuest, "PhoneNo");
            DTpicker_Bdate.DataBindings.Add("Value", BSGuest, "Bday");
            ChkboxFood.DataBindings.Add("Checked", BSResv, "withFood");

            //Room Bindings
            Cbox_Roomtype.DataSource = RoomList.DistinctBy(R => R.Type).ToList();
            Cbox_Roomtype.DisplayMember = "Type";
            Cbox_Roomtype.ValueMember = "Type";

            CBox_RoomNo.DisplayMember = "RoomNumber";
            CBox_RoomNo.ValueMember = "RoomNumber";
            //cboxes bind with fk
            CBox_gender.DataSource = new List<Gender>() { Gender.Male, Gender.Female };
            CBox_gender.DataBindings.Add("SelectedItem", BSGuest, "Gender");

            DTPicker_CheckinDate.DataBindings.Add("Value", BSResv, "From");
            DTPicker_CheckOutDate.DataBindings.Add("Value", BSResv, "To");

            //on changing selected reservation
            lst_Reservations.SelectedIndexChanged += (s, e) => {
                if (BSResv.Current is Reservation Cresv)
                {
                    //Change room type
                    Cbox_Roomtype.SelectedValue = Cresv.Room.Type;

                    //Change room number
                    CBox_RoomNo.DataSource = RoomList.Where(R => R.Type == (RoomType)Cbox_Roomtype.SelectedValue).ToList();


                    CBox_RoomNo.SelectedValue = Cresv.RoomNumber;

                    CurrentRoomNo = Cresv.RoomNumber;
                }
            };

            //on changing selected room
            Cbox_Roomtype.SelectionChangeCommitted += (s, e) =>
            {
                CBox_RoomNo.DataSource = RoomList.Where(R => R.Type == (RoomType)Cbox_Roomtype.SelectedValue).ToList();
                CBox_RoomNo.DisplayMember = "RoomNumber";
                CBox_RoomNo.ValueMember = "RoomNumber";
            };
        }

        private void LoadReservationPage()
        {
            LoadBindings();
        }

        private void loadGridView()
        {
            //var DispData = Context.Reservations.Local.Select(r => new
            var DispData = ReservationsList.Select(r => new
            {
                ReservationID = r.ReservationID,
                Guest = $"{r.Guest.Fname} {r.Guest.Lname}",
                GuestID = r.GuestID,
                PhoneNo = r.Guest.PhoneNo,
                RoomNumber = r.Room.RoomNumber,
                Floor = r.Room.floor,
                CheckinDate = r.From,
                CheckoutDate = r.To,
                WithFood = r.withFood ? "True" : "False",
            });
            BindingSource BSgrd = new();
            BSgrd.DataSource = DispData;
            grd_guests.DataSource = BSgrd;
        }

        private void btn_newreservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewReservation NewResv = new(Context);
            NewResv.FormClosing += (s, e) => this.Show();
            NewResv.Show();
        }

        private void FixDatePickerFormats()
        {
            DTpicker_Bdate.Format = DateTimePickerFormat.Custom;
            DTpicker_Bdate.CustomFormat = "dd/MM/yyyy";
            DTPicker_CheckinDate.Format = DateTimePickerFormat.Custom;
            DTPicker_CheckinDate.CustomFormat = "dd/MM/yyyy";
            DTPicker_CheckOutDate.Format = DateTimePickerFormat.Custom;
            DTPicker_CheckOutDate.CustomFormat = "dd/MM/yyyy";
        }

        private void btn_updatereservation_Click(object sender, EventArgs e)
        {

            if(BSResv.Current is Reservation CResv && CResv != null)
            {
                //before updating the current reservation,
                //one should apply any reference changes to the room
                if(CBox_RoomNo.SelectedItem is Room CRoom && CRoom != null)
                {
                    CResv.RoomNumber = CRoom.RoomNumber;
                    CResv.Room = CRoom;

                    if (CRoom.RoomNumber != CurrentRoomNo)
                    {
                        if(CheckRoomAvailability(CRoom,DTPicker_CheckinDate.Value,DTPicker_CheckOutDate.Value) == false)
                        {
                            MessageBox.Show("Reservation Dates aren't available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }


                }
                Context.Reservations.Update(CResv);
            }

            if (BSGuest.Current is Guest CGuest && CGuest !=null)
                Context.Guests.Update(((Guest)BSGuest.Current));

            int RAffected = Context.SaveChanges();
            MessageBox.Show($"{RAffected} Rows Affected!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_deletereservation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (BSResv.Current is Reservation Cresv && Cresv != null)
                    {
                        Context.Remove(Cresv);
                        int RAffected = Context.SaveChanges();
                        MessageBox.Show($"{RAffected} Rows Affected!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"Error Deleting Reservation Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch { throw; }
            }

        }

        private void btn_finalizebill_Click(object sender, EventArgs e)
        {
            if (BSResv.Current is Reservation CurrResv && CurrResv != null)
            {
                frmpayment NewfrmPayment = new(CurrResv);
                this.Hide();
                NewfrmPayment.Show();
                NewfrmPayment.FormClosed += (s, e) => this.Show();
            }
            else
                MessageBox.Show($"Error Confirming Reservation Data for bill\n Please try again",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckRoomAvailability(Room RoomToCheck, DateTime From, DateTime To)
        {
            foreach (var Period in RoomToCheck.Reservations)
                if ((From >= Period.From && From <= Period.To) || (To >= Period.From && To <= Period.To))
                    return false;
            return true;
        }

    }




}

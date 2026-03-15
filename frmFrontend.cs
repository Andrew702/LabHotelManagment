using LabHotelManagment.Context;
using LabHotelManagment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabHotelManagment
{
    public partial class frmFrontend : Form
    {
        HotelContext Context = new();
        BindingSource BSResv = new();
        BindingSource BSGuest = new();
        BindingSource BSRoom = new();


        public frmFrontend()
        {

            this.FormClosed += (s, e) => Context.Dispose();

            Context.Reservations.Include(R => R.Guest).
                                 Include(R => R.Room).Load();

            InitializeComponent();
            FixDatePickerFormats();
            loadGridView();
            LoadReservationPage();
        }

        private void LoadReservationPage()
        {
            //data bindings for list
            BSResv.DataSource = Context.Reservations.Local.ToBindingList();

            BSGuest.DataSource = BSResv;
            BSGuest.DataMember = "Guest";

            BSRoom.DataSource = BSResv;
            BSRoom.DataMember = "Room";

            //bind with class ListDisplay for proper display
            lst_Reservations.DataSource = BSResv;

            //Simple data binding controls bind with nested BS
            txt_fname.DataBindings.Add("Text", BSGuest, "Fname");
            txt_lname.DataBindings.Add("Text", BSGuest, "Lname");
            txt_pno.DataBindings.Add("Text", BSGuest, "PhoneNo");
            DTpicker_Bdate.DataBindings.Add("Value", BSGuest, "Bday");
            ChkboxFood.DataBindings.Add("Checked", BSResv, "withFood");

            //cboxes bind with fk
            CBox_gender.DataSource = new List<Gender>() { Gender.Male, Gender.Female };
            CBox_gender.DataBindings.Add("SelectedItem", BSGuest, "Gender");

            Cbox_Roomtype.DataSource = Context.Rooms.Local.DistinctBy(R => R.Type).ToList();
            Cbox_Roomtype.DisplayMember = "Type";
            Cbox_Roomtype.ValueMember = "Type";
            Cbox_Roomtype.DataBindings.Add("SelectedValue", BSRoom, "Type");

            
            CBox_RoomNo.DataSource = Context.Rooms.Local.ToList();
            CBox_RoomNo.DisplayMember = "RoomNumber";
            CBox_RoomNo.ValueMember = "RoomNumber";
            CBox_RoomNo.DataBindings.Add("SelectedValue", BSRoom, "RoomNumber");


            DTPicker_CheckinDate.DataBindings.Add("Value", BSResv, "From");
            DTPicker_CheckOutDate.DataBindings.Add("Value", BSResv, "To");
        }

        private void loadGridView()
        {
            var DispData = Context.Reservations.Local.Select(r => new
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

        private void btn_movenext_Click(object sender, EventArgs e) => BSResv.MoveNext();

        private void btn_moveprev_Click(object sender, EventArgs e) => BSResv.MovePrevious();

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






    }



}

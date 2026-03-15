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
            var LDisp = Context.Reservations.Local.
                                Select(R => new ListDisplay()
                                {
                                    DisplayMember = $"{R.Guest.Fname} {R.Guest.Lname} {R.RoomNumber}"
                                ,
                                    ReservationID = R.ReservationID,
                                    Reservation = R
                                })
                                .ToList();

            lst_Reservations.DataSource = LDisp;
            lst_Reservations.DisplayMember = "DisplayMember";
            lst_Reservations.ValueMember = "ReservationID";

            //add binding for BSResv
            lst_Reservations.DataBindings.Add("SelectedValue", BSResv, "ReservationID", true, DataSourceUpdateMode.OnPropertyChanged);

            //Simple data binding controls
            txt_fname.DataBindings.Add("Text", BSGuest, "Fname");
            txt_lname.DataBindings.Add("Text", BSGuest, "Lname");
            txt_pno.DataBindings.Add("Text", BSGuest, "PhoneNo");
            CBox_gender.DataSource = new List<Gender>() { Gender.Male, Gender.Female};
            CBox_gender.DataBindings.Add("SelectedItem",BSGuest,"Gender");
            DTpicker_Bdate.DataBindings.Add("Value",BSGuest,"Bday");

            CBox_RoomNo.DataSource = Context.Rooms.Local.ToList();
            CBox_RoomNo.DisplayMember = "RoomNumber";
            CBox_RoomNo.ValueMember = "RoomNumber";

            CBox_RoomNo.DataBindings.Add("SelectedItem", BSRoom, "RoomNumber");
            Cbox_Roomtype.DataSource = Context.Rooms.Local.DistinctBy(R=>R.Type).ToList();
            Cbox_Roomtype.DisplayMember = "Type";
            Cbox_Roomtype.DataBindings.Add("SelectedItem", BSRoom, "Type");

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
            txt_fname.Clear();
            txt_lname.Clear();
            txt_pno.Clear();
        }

        private void btn_submitdata_Click(object sender, EventArgs e)
        {
            //Guest NewG = new() { Fname = txt_fname.Text,
            //                     Lname = txt_lname.Text,
            //                     Gender = CBox_gender.va}
        }

        private void FixDatePickerFormats()
        {
            DTpicker_Bdate.Format = DateTimePickerFormat.Custom;
            DTpicker_Bdate.CustomFormat = "dd/MM/yyyy";
            DTPicker_CheckinDate.Format = DateTimePickerFormat.Custom;
            DTPicker_CheckinDate.CustomFormat = "dd/MM/yyyy";
            DTPicker_CheckOut.Format = DateTimePickerFormat.Custom;
            DTPicker_CheckOut.CustomFormat = "dd/MM/yyyy";
        }
    }

    public class ListDisplay
    {
        public int ReservationID { set; get; }
        public string DisplayMember { set; get; }

        public Reservation Reservation { set; get; }
    }


}

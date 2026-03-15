using LabHotelManagment.Reservation_Models;
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
        Reservation_Context Context = new();
        BindingSource BSgrd = new();
        public frmFrontend()
        {
            InitializeComponent();
            loadGridView();
            this.FormClosed += (s, e) => Context.Dispose();
        }

        //                queryString = "Select ID, first_name, last_name, phone_number, room_type, room_floor, room_number, break_fast, lunch, dinner, cleaning, towel, s_surprise, supply_status, food_bill from reservation where check_in = '" + "True" + "' AND supply_status= '" + "False" + "'";

        private void loadGridView()
        {
            Context.Reservations.Load();
            BSgrd.DataSource = Context.Reservations.Local.ToBindingList();
            grd_guests.DataSource = BSgrd;
        }


    }
}

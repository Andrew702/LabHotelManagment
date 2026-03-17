using LabHotelManagment.Context;
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
    public partial class frmKitchen : Form
    {
        HotelContext Context = new();
        BindingSource BSResv = new();
        BindingSource BSGuest = new();
        BindingSource BSRoom = new();


        public frmKitchen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmKitchen_Load(object sender, EventArgs e)
        {
            Context.Reservations.Include(R => R.Guest).Include(R => R.Room).Where(R => R.withFood == true).Load();
            BSResv.DataSource = Context.Reservations.Local.ToBindingList();
            BSGuest.DataSource = BSResv;
            BSGuest.DataMember = "Guest";
            BSRoom.DataSource = BSResv;
            BSRoom.DataMember = "Room";

            lst_Reservationswfood.DataSource = BSResv;

            lbl_fname.DataBindings.Add("Text", BSGuest, "Fname", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl_lname.DataBindings.Add("Text", BSGuest, "Lname", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl_Phno.DataBindings.Add("Text", BSGuest, "PhoneNo", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl_Roomno.DataBindings.Add("Text", BSRoom, "RoomNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            chkbox_foodDone.DataBindings.Add("Checked", BSResv, "MealDeliveredFlag", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btn_updatereservation_Click(object sender, EventArgs e)
        {
            int RAffected = Context.SaveChanges();
            MessageBox.Show($"{RAffected} Rows Affected!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_NewMealTime_click(object sender, EventArgs e)
        {
            //record meals not delivered to file where meal missed time is now -3 hrs
            var MealNotDelivered = Context.Reservations.Local
                .Where(R => (R.MealDeliveredFlag == false))
                .Select(R => $"Name: {R.Guest.Fname} {R.Guest.Lname}, " +
                $"Phone: {R.Guest.PhoneNo}, " +
                $"RoomNo: {R.RoomNumber}, Meal Missed at: {DateTime.Now.AddHours(-3)}")
                .ToList();
            AppendToFile<string>("MealsMissed.txt", MealNotDelivered);

            //Reset Meals on every Meal Time
            foreach (var Meal in Context.Reservations.Local)
                Meal.MealDeliveredFlag = false;
            int RAffected = Context.SaveChanges();
            MessageBox.Show($"{RAffected} Rows Affected!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void AppendToFile<T>(string filePath, List<T> items)
        {
            using StreamWriter writer = new StreamWriter(filePath, append: true);
            foreach (var item in items)
            {
                writer.WriteLine(item?.ToString());
            }
        }
    }
}

using LabHotelManagment.Context;
using LabHotelManagment.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabHotelManagment
{
    public partial class frmNewReservation : Form
    {
        HotelContext Context;

        public frmNewReservation(HotelContext _Context)
        {
            Context = _Context;
            InitializeComponent();
            FixDatePickerFormats();
        }

        private void frmNewReservation_Load(object sender, EventArgs e)
        {
            CBox_gender.DataSource = new List<Gender>() { Gender.Male, Gender.Female };

            Cbox_Roomtype.DataSource = Context.Rooms.Local.DistinctBy(R => R.Type).ToList();
            Cbox_Roomtype.DisplayMember = "Type";
            Cbox_Roomtype.ValueMember = "Type";

            if(Cbox_Roomtype.SelectedValue is RoomType RType)
                CBox_RoomNo.DataSource = Context.Rooms.Local.Where(R=>R.Type == RType).ToList();
            CBox_RoomNo.DisplayMember = "RoomNumber";
            CBox_RoomNo.ValueMember = "RoomNumber";

            Cbox_Roomtype.SelectionChangeCommitted += (s, e) =>
            {
                if (Cbox_Roomtype.SelectedValue is RoomType RType)
                    CBox_RoomNo.DataSource = Context.Rooms.Local.Where(R => R.Type == RType).ToList();
                CBox_RoomNo.DisplayMember = "RoomNumber";
                CBox_RoomNo.ValueMember = "RoomNumber";
            };

        }

        private void btn_submitdata_Click(object sender, EventArgs e)
        {
            if (CheckRoomAvailability(((Room)CBox_RoomNo.SelectedItem), DTPicker_CheckinDate.Value, DTPicker_CheckOutDate.Value))
            {
                try
                {
                    Guest NewGuest = new()
                    {
                        Fname = txt_fname.Text,
                        Lname = txt_lname.Text,
                        Gender = ((Gender)CBox_gender.SelectedItem),
                        BDay = DTpicker_Bdate.Value,
                        PhoneNo = txt_pno.Text
                    };
                    Reservation NewResv = new()
                    {
                        GuestID = NewGuest.ID,
                        Guest = NewGuest,
                        Room = (Room)CBox_RoomNo.SelectedItem,
                        RoomNumber = (int)CBox_RoomNo.SelectedValue,
                        From = DTPicker_CheckinDate.Value,
                        To = DTPicker_CheckOutDate.Value,
                        withFood = ChkboxFood.Checked
                    };

                    Context.Add(NewGuest);
                    Context.Add(NewResv);
                    int RAffected = Context.SaveChanges();

                    MessageBox.Show($"{RAffected} Rows Affected!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (RAffected > 0)
                        ClearControls();
                }
                catch { throw; }
            }
            else
            {
                MessageBox.Show("Reservation Dates aren't available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTPicker_CheckinDate.ResetText();
                DTPicker_CheckOutDate.ResetText();
                CBox_RoomNo.ResetText();
                Cbox_Roomtype.ResetText();
                ChkboxFood.ResetText();
            }
        }
        private bool CheckRoomAvailability(Room RoomToCheck, DateTime From, DateTime To)
        {
            foreach (var Period in RoomToCheck.Reservations)
                if ((From >= Period.From && From <= Period.To) || (To >= Period.From && To <= Period.To))
                    return false;
            return true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            this.Close();
        }


        private void ClearControls()
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_pno.Clear();
            DTpicker_Bdate.ResetText();
            DTPicker_CheckinDate.ResetText();
            DTPicker_CheckOutDate.ResetText();
            CBox_gender.ResetText();
            CBox_RoomNo.ResetText();
            Cbox_Roomtype.ResetText();
            ChkboxFood.ResetText();
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

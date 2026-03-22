using LabHotelManagment.Context;
using LabHotelManagment.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LabHotelManagment
{
    public partial class frmNewReservation : Form
    {
        HotelContext Context;
        BindingSource BSGuest;

        public frmNewReservation(HotelContext _Context)
        {
            InitializeComponent();
            FixDatePickerFormats();

            Context = _Context;
            BSGuest = new();
            BSGuest.DataSource = Context.Guests.ToList();
        }

        private void frmNewReservation_Load(object sender, EventArgs e)
        {
            //the newguest check is checked
            CHKbox_newguest.Checked = true;

            CBox_gender.DataSource = new List<Gender>() { Gender.Male, Gender.Female };

            Cbox_Roomtype.DataSource = Context.Rooms.AsEnumerable().DistinctBy(R => R.Type).ToList();
            Cbox_Roomtype.DisplayMember = "Type";
            Cbox_Roomtype.ValueMember = "Type";

            if (Cbox_Roomtype.SelectedValue is RoomType RType)
                CBox_RoomNo.DataSource = Context.Rooms.AsEnumerable().Where(R => R.Type == RType).ToList();
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
                    Guest SGuest;

                    if(CHKbox_newguest.Checked == true)
                    {
                        SGuest = new()
                        {
                            Fname = txt_fname.Text,
                            Lname = txt_lname.Text,
                            Gender = ((Gender)CBox_gender.SelectedItem),
                            BDay = DTpicker_Bdate.Value,
                            PhoneNo = txt_pno.Text
                        };
                        Context.Add(SGuest);
                    }
                    else
                        SGuest = (Guest)BSGuest.Current;
                    



                    Reservation NewResv = new()
                    {
                        GuestID = SGuest.ID,
                        Guest = SGuest,
                        Room = (Room)CBox_RoomNo.SelectedItem,
                        RoomNumber = (int)CBox_RoomNo.SelectedValue,
                        From = DTPicker_CheckinDate.Value,
                        To = DTPicker_CheckOutDate.Value,
                        withFood = ChkboxFood.Checked
                    };

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
            CHKbox_newguest.Checked = true;
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

        private void CHKbox_newguest_CheckedChanged(object sender, EventArgs e)
        {
            if(CHKbox_newguest.Checked == false)
            {
                Cbox_guestCheck.DataSource = BSGuest;
                Cbox_guestCheck.DisplayMember = "ID";

                txt_fname.DataBindings.Add("Text", BSGuest, "Fname");
                txt_lname.DataBindings.Add("Text", BSGuest, "Lname");
                txt_pno.DataBindings.Add("Text", BSGuest, "PhoneNo");

                DTpicker_Bdate.DataBindings.Add("Value", BSGuest, "Bday");
                CBox_gender.DataBindings.Add("SelectedItem", BSGuest, "Gender");
            }
            else
            {
                Cbox_guestCheck.DataBindings.Clear();
                txt_fname.DataBindings.Clear();
                txt_lname.DataBindings.Clear();
                txt_pno.DataBindings.Clear();
                DTpicker_Bdate.DataBindings.Clear();
                CBox_gender.DataBindings.Clear();

                txt_fname.Clear();
                txt_lname.Clear();
                txt_pno.Clear();
                DTpicker_Bdate.ResetText();
                CBox_gender.ResetText();
            }

        }
    }
}

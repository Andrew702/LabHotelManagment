using LabHotelManagment.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;

namespace LabHotelManagment
{
    public partial class frmpayment : Form
    {
        Reservation CurrentResv;
        double staycost { set; get; }
        double foodcost { set; get; }
        double Discount { set; get; }
        public frmpayment(Reservation _CurrentResv)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            CurrentResv = _CurrentResv;
        }

        private void frmpayment_Load(object sender, EventArgs e)
        {
            int NoDays = CalculateNoDays(CurrentResv);
            staycost = (NoDays * 1.0);
            lbl_staycost.Text = staycost.ToString();

            foodcost = (NoDays * 0.5);

            if (CurrentResv.withFood == true)
                lbl_foodcost.Text = foodcost.ToString();
            else
            {
                lbl_foodcost.Text = "0.0";
                foodcost = 0;
            }

            Discount = 0.0;
            txt_discount.Text = "0";

        }

        private int CalculateNoDays(Reservation Resv) => (Resv.To - Resv.From).Days;

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text != string.Empty && double.TryParse(txt_discount.Text, out double Parsed))
            {
                Discount = Parsed;
                lbl_dueamount.Text = (staycost + foodcost - Discount).ToString();
            }
        }

        private void btn_cancelpayment_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using LabHotelManagment.Context;
using LabHotelManagment.Entities;
using Microsoft.VisualBasic;

namespace LabHotelManagment
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit: Are you sure?", 
                                "Warning", 
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning, 
                                MessageBoxDefaultButton.Button2
                                ) == DialogResult.Yes)
                this.Close();
        }

        private void btn_login_Click(object sender,EventArgs e)
        {
            try
            {
                LoginManager Lmanager = new();
                var Cred = Lmanager.GetOne(txt_username.Text);
                if (Cred!= null && Cred.Password.Equals(txt_password.Text))
                {
                    txt_username.Clear();
                    txt_password.Clear();
                    if (Cred.AccType == AccType.Reservation)
                    {
                        this.Hide();
                        frmFrontend hotel_management = new();
                        hotel_management.FormClosed += (s, e) => this.Show();
                        hotel_management.Show();
                    }
                    else
                    {
                        this.Hide();
                        frmKitchen kitchen_managment = new();
                        kitchen_managment.FormClosed += (s, e) => this.Show();
                        kitchen_managment.Show();
                    }

                }
                else
                {
                    txt_username.Clear();
                    txt_password.Clear();
                    MessageBox.Show("Invalid Password, Please try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch { throw new Exception("Error Occured"); }
        }
    }
}

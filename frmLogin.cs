using LabHotelManagment.Login_Models;
using Microsoft.VisualBasic;

namespace LabHotelManagment
{
    public partial class frmLogin : Form
    {
        Login_Context Context = new();
        public frmLogin()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Context.Dispose();
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
                Frontend CREDF = new() { UserName = txt_username.Text, PassWord = txt_password.Text };
                Kitchen CREDK = new() { UserName = txt_username.Text, PassWord = txt_password.Text };
                if(Context.Frontends.AsEnumerable().Where(t=>t.Equals(CREDF)).Count()==1)
                {
                    this.Hide();
                    frmFrontend hotel_management = new();
                    hotel_management.Show();
                }
                else if(Context.Kitchens.AsEnumerable().Where(t=>t.Equals(CREDK)).Count()==1)
                {
                    this.Hide();
                    frmKitchen kitchen_managment = new();
                    kitchen_managment.Show();
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

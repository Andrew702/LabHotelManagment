namespace LabHotelManagment
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Exit = new Button();
            btn_login = new Button();
            txt_username = new TextBox();
            txt_password = new TextBox();
            lbl_Username = new Label();
            lbl_Password = new Label();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(12, 85);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(75, 23);
            btn_Exit.TabIndex = 0;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(317, 85);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 1;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(91, 24);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(301, 23);
            txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(91, 53);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(301, 23);
            txt_password.TabIndex = 2;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Location = new Point(12, 27);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(60, 15);
            lbl_Username.TabIndex = 3;
            lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(12, 56);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(57, 15);
            lbl_Password.TabIndex = 4;
            lbl_Password.Text = "Password";
            // 
            // frmLogin
            // 
            AcceptButton = btn_login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 123);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Username);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(btn_login);
            Controls.Add(btn_Exit);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Exit;
        private Button btn_login;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label lbl_Username;
        private Label lbl_Password;
    }
}

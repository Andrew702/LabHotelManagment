namespace LabHotelManagment
{
    partial class frmFrontend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControl = new TabControl();
            tabReservation = new TabPage();
            btn_submit = new Button();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            txt_bdayyear = new TextBox();
            txt_deptdate = new TextBox();
            txt_bdaymonth = new TextBox();
            txt_entrydate = new TextBox();
            txt_bdayday = new TextBox();
            txt_floor = new TextBox();
            txt_pno = new TextBox();
            txt_noguests = new TextBox();
            txt_lname = new TextBox();
            txt_fname = new TextBox();
            tabViewRes = new TabPage();
            grd_guests = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            TabControl.SuspendLayout();
            tabReservation.SuspendLayout();
            tabViewRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_guests).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabReservation);
            TabControl.Controls.Add(tabViewRes);
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1016, 600);
            TabControl.TabIndex = 0;
            // 
            // tabReservation
            // 
            tabReservation.Controls.Add(btn_submit);
            tabReservation.Controls.Add(label3);
            tabReservation.Controls.Add(label4);
            tabReservation.Controls.Add(label2);
            tabReservation.Controls.Add(label8);
            tabReservation.Controls.Add(label7);
            tabReservation.Controls.Add(label6);
            tabReservation.Controls.Add(label5);
            tabReservation.Controls.Add(label1);
            tabReservation.Controls.Add(txt_bdayyear);
            tabReservation.Controls.Add(txt_deptdate);
            tabReservation.Controls.Add(txt_bdaymonth);
            tabReservation.Controls.Add(txt_entrydate);
            tabReservation.Controls.Add(txt_bdayday);
            tabReservation.Controls.Add(txt_floor);
            tabReservation.Controls.Add(txt_pno);
            tabReservation.Controls.Add(txt_noguests);
            tabReservation.Controls.Add(txt_lname);
            tabReservation.Controls.Add(txt_fname);
            tabReservation.Location = new Point(4, 24);
            tabReservation.Name = "tabReservation";
            tabReservation.Padding = new Padding(3);
            tabReservation.Size = new Size(1008, 572);
            tabReservation.TabIndex = 0;
            tabReservation.Text = "Reservation";
            tabReservation.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            btn_submit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_submit.Location = new Point(31, 503);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(198, 39);
            btn_submit.TabIndex = 10;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(10, 117);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 9;
            label3.Text = "Birthday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(10, 162);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 9;
            label4.Text = "Phone No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(10, 74);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.Location = new Point(315, 159);
            label8.Name = "label8";
            label8.Size = new Size(91, 25);
            label8.TabIndex = 9;
            label8.Text = "DeptDate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(315, 114);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 9;
            label7.Text = "EntryDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(315, 74);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 9;
            label6.Text = "Floor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(315, 28);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 9;
            label5.Text = "No of Guests";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(8, 28);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 9;
            label1.Text = "First Name";
            // 
            // txt_bdayyear
            // 
            txt_bdayyear.Font = new Font("Segoe UI", 14.25F);
            txt_bdayyear.Location = new Point(201, 114);
            txt_bdayyear.Name = "txt_bdayyear";
            txt_bdayyear.Size = new Size(30, 33);
            txt_bdayyear.TabIndex = 1;
            // 
            // txt_deptdate
            // 
            txt_deptdate.Font = new Font("Segoe UI", 14.25F);
            txt_deptdate.Location = new Point(436, 156);
            txt_deptdate.Name = "txt_deptdate";
            txt_deptdate.Size = new Size(100, 33);
            txt_deptdate.TabIndex = 1;
            // 
            // txt_bdaymonth
            // 
            txt_bdaymonth.Font = new Font("Segoe UI", 14.25F);
            txt_bdaymonth.Location = new Point(167, 114);
            txt_bdaymonth.Name = "txt_bdaymonth";
            txt_bdaymonth.Size = new Size(30, 33);
            txt_bdaymonth.TabIndex = 1;
            // 
            // txt_entrydate
            // 
            txt_entrydate.Font = new Font("Segoe UI", 14.25F);
            txt_entrydate.Location = new Point(436, 111);
            txt_entrydate.Name = "txt_entrydate";
            txt_entrydate.Size = new Size(100, 33);
            txt_entrydate.TabIndex = 1;
            // 
            // txt_bdayday
            // 
            txt_bdayday.Font = new Font("Segoe UI", 14.25F);
            txt_bdayday.Location = new Point(131, 114);
            txt_bdayday.Name = "txt_bdayday";
            txt_bdayday.Size = new Size(30, 33);
            txt_bdayday.TabIndex = 1;
            // 
            // txt_floor
            // 
            txt_floor.Font = new Font("Segoe UI", 14.25F);
            txt_floor.Location = new Point(436, 71);
            txt_floor.Name = "txt_floor";
            txt_floor.Size = new Size(100, 33);
            txt_floor.TabIndex = 1;
            // 
            // txt_pno
            // 
            txt_pno.Font = new Font("Segoe UI", 14.25F);
            txt_pno.Location = new Point(131, 159);
            txt_pno.Name = "txt_pno";
            txt_pno.Size = new Size(100, 33);
            txt_pno.TabIndex = 1;
            // 
            // txt_noguests
            // 
            txt_noguests.Font = new Font("Segoe UI", 14.25F);
            txt_noguests.Location = new Point(436, 25);
            txt_noguests.Name = "txt_noguests";
            txt_noguests.Size = new Size(100, 33);
            txt_noguests.TabIndex = 1;
            // 
            // txt_lname
            // 
            txt_lname.Font = new Font("Segoe UI", 14.25F);
            txt_lname.Location = new Point(131, 71);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(100, 33);
            txt_lname.TabIndex = 1;
            // 
            // txt_fname
            // 
            txt_fname.Font = new Font("Segoe UI", 14.25F);
            txt_fname.Location = new Point(129, 25);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(100, 33);
            txt_fname.TabIndex = 1;
            // 
            // tabViewRes
            // 
            tabViewRes.Controls.Add(grd_guests);
            tabViewRes.Location = new Point(4, 24);
            tabViewRes.Name = "tabViewRes";
            tabViewRes.Padding = new Padding(3);
            tabViewRes.Size = new Size(1008, 572);
            tabViewRes.TabIndex = 1;
            tabViewRes.Text = "Reservation Adv. view";
            tabViewRes.UseVisualStyleBackColor = true;
            // 
            // grd_guests
            // 
            grd_guests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_guests.Dock = DockStyle.Fill;
            grd_guests.Location = new Point(3, 3);
            grd_guests.Name = "grd_guests";
            grd_guests.Size = new Size(1002, 566);
            grd_guests.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmFrontend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 599);
            Controls.Add(TabControl);
            Name = "frmFrontend";
            Text = "frmFrontend";
            TabControl.ResumeLayout(false);
            tabReservation.ResumeLayout(false);
            tabReservation.PerformLayout();
            tabViewRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd_guests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage tabReservation;
        private Label label1;
        private TextBox txt_fname;
        private TabPage tabViewRes;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txt_bdayyear;
        private TextBox txt_deptdate;
        private TextBox txt_bdaymonth;
        private TextBox txt_entrydate;
        private TextBox txt_bdayday;
        private TextBox txt_floor;
        private TextBox txt_pno;
        private TextBox txt_noguests;
        private TextBox txt_lname;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btn_submit;
        private DataGridView grd_guests;
    }
}
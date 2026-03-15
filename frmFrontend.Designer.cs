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
            btn_finalizebill = new Button();
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
            label3 = new Label();
            label1 = new Label();
            CBox_reservationedit = new ComboBox();
            btn_newreservation = new Button();
            btn_deletereservation = new Button();
            btn_updatereservation = new Button();
            btn_submitdata = new Button();
            btn_foodandmenu = new Button();
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
            tabReservation.Controls.Add(CBox_reservationedit);
            tabReservation.Controls.Add(btn_updatereservation);
            tabReservation.Controls.Add(btn_deletereservation);
            tabReservation.Controls.Add(btn_newreservation);
            tabReservation.Controls.Add(btn_foodandmenu);
            tabReservation.Controls.Add(btn_submitdata);
            tabReservation.Controls.Add(btn_finalizebill);
            tabReservation.Controls.Add(label1);
            tabReservation.Controls.Add(label3);
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
            // btn_finalizebill
            // 
            btn_finalizebill.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_finalizebill.Location = new Point(338, 458);
            btn_finalizebill.Name = "btn_finalizebill";
            btn_finalizebill.Size = new Size(198, 39);
            btn_finalizebill.TabIndex = 10;
            btn_finalizebill.Text = "Finalize bill";
            btn_finalizebill.UseVisualStyleBackColor = true;
            // 
            // txt_bdayyear
            // 
            txt_bdayyear.Font = new Font("Segoe UI", 14.25F);
            txt_bdayyear.Location = new Point(120, 147);
            txt_bdayyear.Name = "txt_bdayyear";
            txt_bdayyear.Size = new Size(109, 33);
            txt_bdayyear.TabIndex = 1;
            txt_bdayyear.Text = "YYYY";
            // 
            // txt_deptdate
            // 
            txt_deptdate.Font = new Font("Segoe UI", 14.25F);
            txt_deptdate.Location = new Point(353, 201);
            txt_deptdate.Name = "txt_deptdate";
            txt_deptdate.Size = new Size(183, 33);
            txt_deptdate.TabIndex = 1;
            txt_deptdate.Text = "Departure Date";
            // 
            // txt_bdaymonth
            // 
            txt_bdaymonth.Font = new Font("Segoe UI", 14.25F);
            txt_bdaymonth.Location = new Point(62, 147);
            txt_bdaymonth.Name = "txt_bdaymonth";
            txt_bdaymonth.Size = new Size(42, 33);
            txt_bdaymonth.TabIndex = 1;
            txt_bdaymonth.Text = "MM";
            // 
            // txt_entrydate
            // 
            txt_entrydate.Font = new Font("Segoe UI", 14.25F);
            txt_entrydate.Location = new Point(353, 147);
            txt_entrydate.Name = "txt_entrydate";
            txt_entrydate.Size = new Size(183, 33);
            txt_entrydate.TabIndex = 1;
            txt_entrydate.Text = "Entry Date";
            // 
            // txt_bdayday
            // 
            txt_bdayday.Font = new Font("Segoe UI", 14.25F);
            txt_bdayday.Location = new Point(8, 147);
            txt_bdayday.Name = "txt_bdayday";
            txt_bdayday.Size = new Size(42, 33);
            txt_bdayday.TabIndex = 1;
            txt_bdayday.Text = "DD";
            // 
            // txt_floor
            // 
            txt_floor.Font = new Font("Segoe UI", 14.25F);
            txt_floor.Location = new Point(353, 71);
            txt_floor.Name = "txt_floor";
            txt_floor.Size = new Size(183, 33);
            txt_floor.TabIndex = 1;
            txt_floor.Text = "Room Type";
            // 
            // txt_pno
            // 
            txt_pno.Font = new Font("Segoe UI", 14.25F);
            txt_pno.Location = new Point(10, 201);
            txt_pno.Name = "txt_pno";
            txt_pno.Size = new Size(221, 33);
            txt_pno.TabIndex = 1;
            txt_pno.Text = "Phone Number";
            // 
            // txt_noguests
            // 
            txt_noguests.Font = new Font("Segoe UI", 14.25F);
            txt_noguests.Location = new Point(353, 25);
            txt_noguests.Name = "txt_noguests";
            txt_noguests.Size = new Size(183, 33);
            txt_noguests.TabIndex = 1;
            txt_noguests.Text = "# of guests";
            // 
            // txt_lname
            // 
            txt_lname.Font = new Font("Segoe UI", 14.25F);
            txt_lname.Location = new Point(10, 71);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(221, 33);
            txt_lname.TabIndex = 1;
            txt_lname.Text = "Last Name";
            // 
            // txt_fname
            // 
            txt_fname.Font = new Font("Segoe UI", 14.25F);
            txt_fname.Location = new Point(10, 25);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(219, 33);
            txt_fname.TabIndex = 1;
            txt_fname.Text = "First Name";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(10, 119);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 9;
            label3.Text = "Birthday";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(749, 25);
            label1.Name = "label1";
            label1.Size = new Size(223, 25);
            label1.TabIndex = 9;
            label1.Text = "Select Reservation to Edit";
            // 
            // CBox_reservationedit
            // 
            CBox_reservationedit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBox_reservationedit.FormattingEnabled = true;
            CBox_reservationedit.Location = new Point(749, 71);
            CBox_reservationedit.Name = "CBox_reservationedit";
            CBox_reservationedit.Size = new Size(223, 33);
            CBox_reservationedit.TabIndex = 11;
            // 
            // btn_newreservation
            // 
            btn_newreservation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_newreservation.Location = new Point(774, 503);
            btn_newreservation.Name = "btn_newreservation";
            btn_newreservation.Size = new Size(198, 39);
            btn_newreservation.TabIndex = 10;
            btn_newreservation.Text = "New Reservation";
            btn_newreservation.UseVisualStyleBackColor = true;
            // 
            // btn_deletereservation
            // 
            btn_deletereservation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_deletereservation.Location = new Point(774, 405);
            btn_deletereservation.Name = "btn_deletereservation";
            btn_deletereservation.Size = new Size(198, 39);
            btn_deletereservation.TabIndex = 10;
            btn_deletereservation.Text = "Delete";
            btn_deletereservation.UseVisualStyleBackColor = true;
            // 
            // btn_updatereservation
            // 
            btn_updatereservation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_updatereservation.Location = new Point(774, 360);
            btn_updatereservation.Name = "btn_updatereservation";
            btn_updatereservation.Size = new Size(198, 39);
            btn_updatereservation.TabIndex = 10;
            btn_updatereservation.Text = "Update";
            btn_updatereservation.UseVisualStyleBackColor = true;
            // 
            // btn_submitdata
            // 
            btn_submitdata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_submitdata.Location = new Point(338, 503);
            btn_submitdata.Name = "btn_submitdata";
            btn_submitdata.Size = new Size(198, 39);
            btn_submitdata.TabIndex = 10;
            btn_submitdata.Text = "Submit";
            btn_submitdata.UseVisualStyleBackColor = true;
            // 
            // btn_foodandmenu
            // 
            btn_foodandmenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_foodandmenu.Location = new Point(338, 360);
            btn_foodandmenu.Name = "btn_foodandmenu";
            btn_foodandmenu.Size = new Size(198, 39);
            btn_foodandmenu.TabIndex = 10;
            btn_foodandmenu.Text = "Food and Menu";
            btn_foodandmenu.UseVisualStyleBackColor = true;
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
        private TextBox txt_fname;
        private TabPage tabViewRes;
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
        private Button btn_finalizebill;
        private DataGridView grd_guests;
        private Label label3;
        private ComboBox CBox_reservationedit;
        private Button btn_updatereservation;
        private Button btn_deletereservation;
        private Button btn_newreservation;
        private Button btn_foodandmenu;
        private Button btn_submitdata;
        private Label label1;
    }
}
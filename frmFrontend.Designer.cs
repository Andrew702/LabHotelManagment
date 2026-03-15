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
            btn_moveNext = new Button();
            btn_moveprev = new Button();
            lst_Reservations = new ListBox();
            DTPicker_CheckOut = new DateTimePicker();
            DTPicker_CheckinDate = new DateTimePicker();
            DTpicker_Bdate = new DateTimePicker();
            CBox_RoomNo = new ComboBox();
            Cbox_Roomtype = new ComboBox();
            CBox_gender = new ComboBox();
            btn_updatereservation = new Button();
            btn_deletereservation = new Button();
            btn_newreservation = new Button();
            btn_foodandmenu = new Button();
            btn_submitdata = new Button();
            btn_finalizebill = new Button();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txt_pno = new TextBox();
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
            tabReservation.Controls.Add(btn_moveNext);
            tabReservation.Controls.Add(btn_moveprev);
            tabReservation.Controls.Add(lst_Reservations);
            tabReservation.Controls.Add(DTPicker_CheckOut);
            tabReservation.Controls.Add(DTPicker_CheckinDate);
            tabReservation.Controls.Add(DTpicker_Bdate);
            tabReservation.Controls.Add(CBox_RoomNo);
            tabReservation.Controls.Add(Cbox_Roomtype);
            tabReservation.Controls.Add(CBox_gender);
            tabReservation.Controls.Add(btn_updatereservation);
            tabReservation.Controls.Add(btn_deletereservation);
            tabReservation.Controls.Add(btn_newreservation);
            tabReservation.Controls.Add(btn_foodandmenu);
            tabReservation.Controls.Add(btn_submitdata);
            tabReservation.Controls.Add(btn_finalizebill);
            tabReservation.Controls.Add(label1);
            tabReservation.Controls.Add(label4);
            tabReservation.Controls.Add(label2);
            tabReservation.Controls.Add(label6);
            tabReservation.Controls.Add(label5);
            tabReservation.Controls.Add(label3);
            tabReservation.Controls.Add(txt_pno);
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
            // btn_moveNext
            // 
            btn_moveNext.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_moveNext.Location = new Point(869, 355);
            btn_moveNext.Name = "btn_moveNext";
            btn_moveNext.Size = new Size(103, 37);
            btn_moveNext.TabIndex = 16;
            btn_moveNext.Text = ">";
            btn_moveNext.UseVisualStyleBackColor = true;
            btn_moveNext.Click += btn_movenext_Click;
            // 
            // btn_moveprev
            // 
            btn_moveprev.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_moveprev.Location = new Point(749, 355);
            btn_moveprev.Name = "btn_moveprev";
            btn_moveprev.Size = new Size(103, 37);
            btn_moveprev.TabIndex = 15;
            btn_moveprev.Text = "<";
            btn_moveprev.UseVisualStyleBackColor = true;
            btn_moveprev.Click += btn_moveprev_Click;
            // 
            // lst_Reservations
            // 
            lst_Reservations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lst_Reservations.FormattingEnabled = true;
            lst_Reservations.Location = new Point(749, 51);
            lst_Reservations.Name = "lst_Reservations";
            lst_Reservations.Size = new Size(223, 298);
            lst_Reservations.TabIndex = 14;
            // 
            // DTPicker_CheckOut
            // 
            DTPicker_CheckOut.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTPicker_CheckOut.Format = DateTimePickerFormat.Short;
            DTPicker_CheckOut.Location = new Point(353, 274);
            DTPicker_CheckOut.Name = "DTPicker_CheckOut";
            DTPicker_CheckOut.Size = new Size(225, 33);
            DTPicker_CheckOut.TabIndex = 13;
            DTPicker_CheckOut.Value = new DateTime(2026, 3, 15, 0, 0, 0, 0);
            // 
            // DTPicker_CheckinDate
            // 
            DTPicker_CheckinDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTPicker_CheckinDate.Format = DateTimePickerFormat.Short;
            DTPicker_CheckinDate.Location = new Point(353, 186);
            DTPicker_CheckinDate.Name = "DTPicker_CheckinDate";
            DTPicker_CheckinDate.Size = new Size(225, 33);
            DTPicker_CheckinDate.TabIndex = 13;
            // 
            // DTpicker_Bdate
            // 
            DTpicker_Bdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTpicker_Bdate.Format = DateTimePickerFormat.Short;
            DTpicker_Bdate.Location = new Point(19, 184);
            DTpicker_Bdate.Name = "DTpicker_Bdate";
            DTpicker_Bdate.Size = new Size(225, 33);
            DTpicker_Bdate.TabIndex = 13;
            // 
            // CBox_RoomNo
            // 
            CBox_RoomNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBox_RoomNo.FormattingEnabled = true;
            CBox_RoomNo.Location = new Point(353, 100);
            CBox_RoomNo.Name = "CBox_RoomNo";
            CBox_RoomNo.Size = new Size(225, 33);
            CBox_RoomNo.TabIndex = 12;
            CBox_RoomNo.Text = "RoomNo";
            // 
            // Cbox_Roomtype
            // 
            Cbox_Roomtype.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cbox_Roomtype.FormattingEnabled = true;
            Cbox_Roomtype.Location = new Point(353, 54);
            Cbox_Roomtype.Name = "Cbox_Roomtype";
            Cbox_Roomtype.Size = new Size(225, 33);
            Cbox_Roomtype.TabIndex = 12;
            Cbox_Roomtype.Text = "RoomType";
            // 
            // CBox_gender
            // 
            CBox_gender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBox_gender.FormattingEnabled = true;
            CBox_gender.Location = new Point(19, 276);
            CBox_gender.Name = "CBox_gender";
            CBox_gender.Size = new Size(225, 33);
            CBox_gender.TabIndex = 12;
            CBox_gender.Text = "Gender";
            // 
            // btn_updatereservation
            // 
            btn_updatereservation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_updatereservation.Location = new Point(749, 413);
            btn_updatereservation.Name = "btn_updatereservation";
            btn_updatereservation.Size = new Size(223, 39);
            btn_updatereservation.TabIndex = 10;
            btn_updatereservation.Text = "Update";
            btn_updatereservation.UseVisualStyleBackColor = true;
            // 
            // btn_deletereservation
            // 
            btn_deletereservation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_deletereservation.Location = new Point(749, 458);
            btn_deletereservation.Name = "btn_deletereservation";
            btn_deletereservation.Size = new Size(223, 39);
            btn_deletereservation.TabIndex = 10;
            btn_deletereservation.Text = "Delete";
            btn_deletereservation.UseVisualStyleBackColor = true;
            // 
            // btn_newreservation
            // 
            btn_newreservation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_newreservation.Location = new Point(749, 503);
            btn_newreservation.Name = "btn_newreservation";
            btn_newreservation.Size = new Size(223, 39);
            btn_newreservation.TabIndex = 10;
            btn_newreservation.Text = "New Reservation";
            btn_newreservation.UseVisualStyleBackColor = true;
            btn_newreservation.Click += btn_newreservation_Click;
            // 
            // btn_foodandmenu
            // 
            btn_foodandmenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_foodandmenu.Location = new Point(353, 413);
            btn_foodandmenu.Name = "btn_foodandmenu";
            btn_foodandmenu.Size = new Size(198, 39);
            btn_foodandmenu.TabIndex = 10;
            btn_foodandmenu.Text = "Food and Menu";
            btn_foodandmenu.UseVisualStyleBackColor = true;
            // 
            // btn_submitdata
            // 
            btn_submitdata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_submitdata.Location = new Point(353, 503);
            btn_submitdata.Name = "btn_submitdata";
            btn_submitdata.Size = new Size(198, 39);
            btn_submitdata.TabIndex = 10;
            btn_submitdata.Text = "Submit";
            btn_submitdata.UseVisualStyleBackColor = true;
            btn_submitdata.Click += btn_submitdata_Click;
            // 
            // btn_finalizebill
            // 
            btn_finalizebill.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_finalizebill.Location = new Point(353, 458);
            btn_finalizebill.Name = "btn_finalizebill";
            btn_finalizebill.Size = new Size(198, 39);
            btn_finalizebill.TabIndex = 10;
            btn_finalizebill.Text = "Finalize bill";
            btn_finalizebill.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(749, 16);
            label1.Name = "label1";
            label1.Size = new Size(223, 25);
            label1.TabIndex = 9;
            label1.Text = "Select Reservation to Edit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(404, 16);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 9;
            label4.Text = "Room Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(70, 16);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 9;
            label2.Text = "Guest Details";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(418, 234);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 9;
            label6.Text = "CheckOut";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(426, 146);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 9;
            label5.Text = "CheckIn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(90, 146);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 9;
            label3.Text = "Birthday";
            // 
            // txt_pno
            // 
            txt_pno.Font = new Font("Segoe UI", 14.25F);
            txt_pno.Location = new Point(19, 230);
            txt_pno.Name = "txt_pno";
            txt_pno.Size = new Size(225, 33);
            txt_pno.TabIndex = 1;
            txt_pno.Text = "Phone Number";
            // 
            // txt_lname
            // 
            txt_lname.Font = new Font("Segoe UI", 14.25F);
            txt_lname.Location = new Point(19, 100);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(225, 33);
            txt_lname.TabIndex = 1;
            txt_lname.Text = "Last Name";
            // 
            // txt_fname
            // 
            txt_fname.Font = new Font("Segoe UI", 14.25F);
            txt_fname.Location = new Point(19, 54);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(225, 33);
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
        private TextBox txt_pno;
        private TextBox txt_lname;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btn_finalizebill;
        private DataGridView grd_guests;
        private Label label3;
        private Button btn_updatereservation;
        private Button btn_deletereservation;
        private Button btn_newreservation;
        private Button btn_foodandmenu;
        private Button btn_submitdata;
        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox Cbox_Roomtype;
        private ComboBox CBox_gender;
        private DateTimePicker DTPicker_CheckOut;
        private DateTimePicker DTPicker_CheckinDate;
        private DateTimePicker DTpicker_Bdate;
        private Label label6;
        private Label label5;
        private ListBox lst_Reservations;
        private ComboBox CBox_RoomNo;
        private Button btn_moveNext;
        private Button btn_moveprev;
    }
}
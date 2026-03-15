namespace LabHotelManagment
{
    partial class frmNewReservation
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
            ChkboxFood = new CheckBox();
            DTPicker_CheckOutDate = new DateTimePicker();
            DTPicker_CheckinDate = new DateTimePicker();
            DTpicker_Bdate = new DateTimePicker();
            CBox_RoomNo = new ComboBox();
            Cbox_Roomtype = new ComboBox();
            CBox_gender = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txt_pno = new TextBox();
            txt_lname = new TextBox();
            txt_fname = new TextBox();
            btn_submitdata = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // ChkboxFood
            // 
            ChkboxFood.AutoSize = true;
            ChkboxFood.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChkboxFood.Location = new Point(336, 314);
            ChkboxFood.Name = "ChkboxFood";
            ChkboxFood.Size = new Size(73, 29);
            ChkboxFood.TabIndex = 32;
            ChkboxFood.Text = "Food";
            ChkboxFood.UseVisualStyleBackColor = true;
            // 
            // DTPicker_CheckOutDate
            // 
            DTPicker_CheckOutDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTPicker_CheckOutDate.Format = DateTimePickerFormat.Short;
            DTPicker_CheckOutDate.Location = new Point(260, 275);
            DTPicker_CheckOutDate.Name = "DTPicker_CheckOutDate";
            DTPicker_CheckOutDate.Size = new Size(225, 33);
            DTPicker_CheckOutDate.TabIndex = 29;
            DTPicker_CheckOutDate.Value = new DateTime(2026, 3, 15, 0, 0, 0, 0);
            // 
            // DTPicker_CheckinDate
            // 
            DTPicker_CheckinDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTPicker_CheckinDate.Format = DateTimePickerFormat.Short;
            DTPicker_CheckinDate.Location = new Point(260, 183);
            DTPicker_CheckinDate.Name = "DTPicker_CheckinDate";
            DTPicker_CheckinDate.Size = new Size(225, 33);
            DTPicker_CheckinDate.TabIndex = 30;
            // 
            // DTpicker_Bdate
            // 
            DTpicker_Bdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTpicker_Bdate.Format = DateTimePickerFormat.Short;
            DTpicker_Bdate.Location = new Point(12, 183);
            DTpicker_Bdate.Name = "DTpicker_Bdate";
            DTpicker_Bdate.Size = new Size(225, 33);
            DTpicker_Bdate.TabIndex = 31;
            // 
            // CBox_RoomNo
            // 
            CBox_RoomNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBox_RoomNo.FormattingEnabled = true;
            CBox_RoomNo.Location = new Point(260, 99);
            CBox_RoomNo.Name = "CBox_RoomNo";
            CBox_RoomNo.Size = new Size(225, 33);
            CBox_RoomNo.TabIndex = 26;
            CBox_RoomNo.Text = "RoomNo";
            // 
            // Cbox_Roomtype
            // 
            Cbox_Roomtype.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cbox_Roomtype.FormattingEnabled = true;
            Cbox_Roomtype.Location = new Point(260, 53);
            Cbox_Roomtype.Name = "Cbox_Roomtype";
            Cbox_Roomtype.Size = new Size(225, 33);
            Cbox_Roomtype.TabIndex = 27;
            Cbox_Roomtype.Text = "RoomType";
            // 
            // CBox_gender
            // 
            CBox_gender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBox_gender.FormattingEnabled = true;
            CBox_gender.Location = new Point(12, 275);
            CBox_gender.Name = "CBox_gender";
            CBox_gender.Size = new Size(225, 33);
            CBox_gender.TabIndex = 28;
            CBox_gender.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(311, 13);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 21;
            label4.Text = "Room Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(63, 15);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 22;
            label2.Text = "Guest Details";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(303, 232);
            label6.Name = "label6";
            label6.Size = new Size(138, 25);
            label6.TabIndex = 23;
            label6.Text = "CheckOut Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(311, 145);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 24;
            label5.Text = "CheckIn Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(83, 145);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 25;
            label3.Text = "Birthday";
            // 
            // txt_pno
            // 
            txt_pno.Font = new Font("Segoe UI", 14.25F);
            txt_pno.Location = new Point(12, 229);
            txt_pno.Name = "txt_pno";
            txt_pno.PlaceholderText = "Phone Number";
            txt_pno.Size = new Size(225, 33);
            txt_pno.TabIndex = 18;
            // 
            // txt_lname
            // 
            txt_lname.Font = new Font("Segoe UI", 14.25F);
            txt_lname.Location = new Point(12, 99);
            txt_lname.Name = "txt_lname";
            txt_lname.PlaceholderText = "Last Name";
            txt_lname.Size = new Size(225, 33);
            txt_lname.TabIndex = 19;
            // 
            // txt_fname
            // 
            txt_fname.Font = new Font("Segoe UI", 14.25F);
            txt_fname.Location = new Point(12, 53);
            txt_fname.Name = "txt_fname";
            txt_fname.PlaceholderText = "First Name";
            txt_fname.Size = new Size(225, 33);
            txt_fname.TabIndex = 20;
            // 
            // btn_submitdata
            // 
            btn_submitdata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_submitdata.Location = new Point(287, 371);
            btn_submitdata.Name = "btn_submitdata";
            btn_submitdata.Size = new Size(198, 39);
            btn_submitdata.TabIndex = 33;
            btn_submitdata.Text = "Submit";
            btn_submitdata.UseVisualStyleBackColor = true;
            btn_submitdata.Click += btn_submitdata_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancel.Location = new Point(12, 371);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(198, 39);
            btn_cancel.TabIndex = 33;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // frmNewReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 422);
            Controls.Add(btn_cancel);
            Controls.Add(btn_submitdata);
            Controls.Add(ChkboxFood);
            Controls.Add(DTPicker_CheckOutDate);
            Controls.Add(DTPicker_CheckinDate);
            Controls.Add(DTpicker_Bdate);
            Controls.Add(CBox_RoomNo);
            Controls.Add(Cbox_Roomtype);
            Controls.Add(CBox_gender);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txt_pno);
            Controls.Add(txt_lname);
            Controls.Add(txt_fname);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmNewReservation";
            Text = "frmNewReservation";
            Load += frmNewReservation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ChkboxFood;
        private DateTimePicker DTPicker_CheckOutDate;
        private DateTimePicker DTPicker_CheckinDate;
        private DateTimePicker DTpicker_Bdate;
        private ComboBox CBox_RoomNo;
        private ComboBox Cbox_Roomtype;
        private ComboBox CBox_gender;
        private Label label4;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txt_pno;
        private TextBox txt_lname;
        private TextBox txt_fname;
        private Button btn_submitdata;
        private Button btn_cancel;
    }
}
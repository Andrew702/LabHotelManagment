namespace LabHotelManagment
{
    partial class frmKitchen
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
            label1 = new Label();
            label2 = new Label();
            lst_Reservationswfood = new ListBox();
            lbl_Roomno = new Label();
            chkbox_foodDone = new CheckBox();
            lbl_lname = new Label();
            lbl_Phno = new Label();
            lbl_fname = new Label();
            btn_updatereservation = new Button();
            btn_newmealtime = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 0;
            label1.Text = "Food Room Service";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(63, 75);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 12;
            label2.Text = "Guest Details";
            // 
            // lst_Reservationswfood
            // 
            lst_Reservationswfood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lst_Reservationswfood.FormattingEnabled = true;
            lst_Reservationswfood.Location = new Point(346, 72);
            lst_Reservationswfood.Name = "lst_Reservationswfood";
            lst_Reservationswfood.Size = new Size(223, 340);
            lst_Reservationswfood.TabIndex = 15;
            // 
            // lbl_Roomno
            // 
            lbl_Roomno.BorderStyle = BorderStyle.FixedSingle;
            lbl_Roomno.Font = new Font("Segoe UI", 14.25F);
            lbl_Roomno.Location = new Point(12, 237);
            lbl_Roomno.Name = "lbl_Roomno";
            lbl_Roomno.Size = new Size(225, 33);
            lbl_Roomno.TabIndex = 16;
            lbl_Roomno.Text = "Room No";
            lbl_Roomno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkbox_foodDone
            // 
            chkbox_foodDone.AutoSize = true;
            chkbox_foodDone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkbox_foodDone.Location = new Point(49, 273);
            chkbox_foodDone.Name = "chkbox_foodDone";
            chkbox_foodDone.Size = new Size(153, 29);
            chkbox_foodDone.TabIndex = 17;
            chkbox_foodDone.Text = "MealDelivered";
            chkbox_foodDone.UseVisualStyleBackColor = true;
            // 
            // lbl_lname
            // 
            lbl_lname.BorderStyle = BorderStyle.FixedSingle;
            lbl_lname.Font = new Font("Segoe UI", 14.25F);
            lbl_lname.Location = new Point(12, 153);
            lbl_lname.Name = "lbl_lname";
            lbl_lname.Size = new Size(225, 33);
            lbl_lname.TabIndex = 16;
            lbl_lname.Text = "Last Name";
            lbl_lname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Phno
            // 
            lbl_Phno.BorderStyle = BorderStyle.FixedSingle;
            lbl_Phno.Font = new Font("Segoe UI", 14.25F);
            lbl_Phno.Location = new Point(12, 195);
            lbl_Phno.Name = "lbl_Phno";
            lbl_Phno.Size = new Size(225, 33);
            lbl_Phno.TabIndex = 16;
            lbl_Phno.Text = "Phone Number";
            lbl_Phno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_fname
            // 
            lbl_fname.BorderStyle = BorderStyle.FixedSingle;
            lbl_fname.Font = new Font("Segoe UI", 14.25F);
            lbl_fname.Location = new Point(12, 111);
            lbl_fname.Name = "lbl_fname";
            lbl_fname.Size = new Size(225, 33);
            lbl_fname.TabIndex = 16;
            lbl_fname.Text = "First Name";
            lbl_fname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_updatereservation
            // 
            btn_updatereservation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_updatereservation.Location = new Point(12, 308);
            btn_updatereservation.Name = "btn_updatereservation";
            btn_updatereservation.Size = new Size(225, 39);
            btn_updatereservation.TabIndex = 18;
            btn_updatereservation.Text = "Update";
            btn_updatereservation.UseVisualStyleBackColor = true;
            btn_updatereservation.Click += btn_updatereservation_Click;
            // 
            // btn_newmealtime
            // 
            btn_newmealtime.BackColor = SystemColors.GradientActiveCaption;
            btn_newmealtime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_newmealtime.Location = new Point(12, 353);
            btn_newmealtime.Name = "btn_newmealtime";
            btn_newmealtime.Size = new Size(225, 39);
            btn_newmealtime.TabIndex = 18;
            btn_newmealtime.Text = "New Meal Time";
            btn_newmealtime.UseVisualStyleBackColor = false;
            btn_newmealtime.Click += btn_NewMealTime_click;
            // 
            // frmKitchen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 424);
            Controls.Add(btn_newmealtime);
            Controls.Add(btn_updatereservation);
            Controls.Add(chkbox_foodDone);
            Controls.Add(lbl_fname);
            Controls.Add(lbl_Phno);
            Controls.Add(lbl_lname);
            Controls.Add(lbl_Roomno);
            Controls.Add(lst_Reservationswfood);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmKitchen";
            Text = "frmKitchen";
            Load += frmKitchen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lst_Reservationswfood;
        private Label lbl_Roomno;
        private CheckBox chkbox_foodDone;
        private Label lbl_lname;
        private Label lbl_Phno;
        private Label lbl_fname;
        private Button btn_updatereservation;
        private Button btn_newmealtime;
    }
}
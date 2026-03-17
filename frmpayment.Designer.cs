namespace LabHotelManagment
{
    partial class frmpayment
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
            lbl_staycost = new Label();
            label1 = new Label();
            btn_paid = new Button();
            btn_cancelpayment = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl_foodcost = new Label();
            label6 = new Label();
            label5 = new Label();
            lbl_dueamount = new Label();
            txt_discount = new TextBox();
            SuspendLayout();
            // 
            // lbl_staycost
            // 
            lbl_staycost.AutoSize = true;
            lbl_staycost.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_staycost.Location = new Point(183, 55);
            lbl_staycost.Name = "lbl_staycost";
            lbl_staycost.Size = new Size(22, 25);
            lbl_staycost.TabIndex = 0;
            lbl_staycost.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "Receipt";
            // 
            // btn_paid
            // 
            btn_paid.Font = new Font("Segoe UI", 14F);
            btn_paid.Location = new Point(28, 289);
            btn_paid.Name = "btn_paid";
            btn_paid.Size = new Size(93, 34);
            btn_paid.TabIndex = 1;
            btn_paid.Text = "Pay";
            btn_paid.UseVisualStyleBackColor = true;
            // 
            // btn_cancelpayment
            // 
            btn_cancelpayment.Font = new Font("Segoe UI", 14F);
            btn_cancelpayment.Location = new Point(160, 289);
            btn_cancelpayment.Name = "btn_cancelpayment";
            btn_cancelpayment.Size = new Size(93, 34);
            btn_cancelpayment.TabIndex = 1;
            btn_cancelpayment.Text = "Cancel";
            btn_cancelpayment.UseVisualStyleBackColor = true;
            btn_cancelpayment.Click += btn_cancelpayment_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 55);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 0;
            label2.Text = "Stay Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 105);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 0;
            label3.Text = "Food Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 155);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 0;
            label4.Text = "Discount";
            // 
            // lbl_foodcost
            // 
            lbl_foodcost.AutoSize = true;
            lbl_foodcost.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_foodcost.Location = new Point(183, 105);
            lbl_foodcost.Name = "lbl_foodcost";
            lbl_foodcost.Size = new Size(22, 25);
            lbl_foodcost.TabIndex = 0;
            lbl_foodcost.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 230);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 0;
            label6.Text = "Due Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(242, 55);
            label5.Name = "label5";
            label5.Size = new Size(22, 200);
            label5.TabIndex = 0;
            label5.Text = "$\r\n\r\n$\r\n\r\n$\r\n\r\n\r\n$";
            // 
            // lbl_dueamount
            // 
            lbl_dueamount.AutoSize = true;
            lbl_dueamount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_dueamount.Location = new Point(183, 230);
            lbl_dueamount.Name = "lbl_dueamount";
            lbl_dueamount.Size = new Size(22, 25);
            lbl_dueamount.TabIndex = 0;
            lbl_dueamount.Text = "0";
            // 
            // txt_discount
            // 
            txt_discount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_discount.Location = new Point(161, 152);
            txt_discount.Name = "txt_discount";
            txt_discount.Size = new Size(65, 33);
            txt_discount.TabIndex = 2;
            txt_discount.TextAlign = HorizontalAlignment.Center;
            txt_discount.TextChanged += txt_discount_TextChanged;
            // 
            // frmpayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 335);
            Controls.Add(txt_discount);
            Controls.Add(btn_cancelpayment);
            Controls.Add(btn_paid);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_dueamount);
            Controls.Add(lbl_foodcost);
            Controls.Add(label5);
            Controls.Add(lbl_staycost);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmpayment";
            Text = "frm_payment";
            Load += frmpayment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_staycost;
        private Label label1;
        private Button btn_paid;
        private Button btn_cancelpayment;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_foodcost;
        private Label label6;
        private Label label5;
        private Label lbl_dueamount;
        private TextBox txt_discount;
    }
}
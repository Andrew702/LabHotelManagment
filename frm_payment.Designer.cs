namespace LabHotelManagment
{
    partial class frm_payment
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
            txt_totalamount = new Label();
            label1 = new Label();
            btn_paid = new Button();
            btn_cancelpayment = new Button();
            SuspendLayout();
            // 
            // txt_totalamount
            // 
            txt_totalamount.AutoSize = true;
            txt_totalamount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_totalamount.Location = new Point(253, 25);
            txt_totalamount.Name = "txt_totalamount";
            txt_totalamount.Size = new Size(22, 25);
            txt_totalamount.TabIndex = 0;
            txt_totalamount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 25);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 0;
            label1.Text = "Your total to pay:";
            // 
            // btn_paid
            // 
            btn_paid.Font = new Font("Segoe UI", 14F);
            btn_paid.Location = new Point(36, 71);
            btn_paid.Name = "btn_paid";
            btn_paid.Size = new Size(93, 34);
            btn_paid.TabIndex = 1;
            btn_paid.Text = "Pay";
            btn_paid.UseVisualStyleBackColor = true;
            // 
            // btn_cancelpayment
            // 
            btn_cancelpayment.Font = new Font("Segoe UI", 14F);
            btn_cancelpayment.Location = new Point(207, 71);
            btn_cancelpayment.Name = "btn_cancelpayment";
            btn_cancelpayment.Size = new Size(93, 34);
            btn_cancelpayment.TabIndex = 1;
            btn_cancelpayment.Text = "Cancel";
            btn_cancelpayment.UseVisualStyleBackColor = true;
            // 
            // frm_payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 154);
            Controls.Add(btn_cancelpayment);
            Controls.Add(btn_paid);
            Controls.Add(label1);
            Controls.Add(txt_totalamount);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_payment";
            Text = "frm_payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_totalamount;
        private Label label1;
        private Button btn_paid;
        private Button btn_cancelpayment;
    }
}
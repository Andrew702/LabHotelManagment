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
            label3 = new Label();
            label4 = new Label();
            txt_breakfastcount = new TextBox();
            txt_lunchCount = new TextBox();
            txt_dinnercount = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(180, 28);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Food and Menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(25, 115);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 0;
            label2.Text = "Breakfast";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(223, 115);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 0;
            label3.Text = "Lunch";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(430, 115);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 0;
            label4.Text = "Dinner";
            // 
            // txt_breakfastcount
            // 
            txt_breakfastcount.Font = new Font("Segoe UI", 14F);
            txt_breakfastcount.Location = new Point(25, 155);
            txt_breakfastcount.Name = "txt_breakfastcount";
            txt_breakfastcount.Size = new Size(100, 32);
            txt_breakfastcount.TabIndex = 1;
            txt_breakfastcount.Text = "Quantity";
            // 
            // txt_lunchCount
            // 
            txt_lunchCount.Font = new Font("Segoe UI", 14F);
            txt_lunchCount.Location = new Point(213, 155);
            txt_lunchCount.Name = "txt_lunchCount";
            txt_lunchCount.Size = new Size(100, 32);
            txt_lunchCount.TabIndex = 1;
            txt_lunchCount.Text = "Quantity";
            // 
            // txt_dinnercount
            // 
            txt_dinnercount.Font = new Font("Segoe UI", 14F);
            txt_dinnercount.Location = new Point(430, 155);
            txt_dinnercount.Name = "txt_dinnercount";
            txt_dinnercount.Size = new Size(100, 32);
            txt_dinnercount.TabIndex = 1;
            txt_dinnercount.Text = "Quantity";
            // 
            // frmKitchen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 318);
            Controls.Add(txt_dinnercount);
            Controls.Add(txt_lunchCount);
            Controls.Add(txt_breakfastcount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmKitchen";
            Text = "frmKitchen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_breakfastcount;
        private TextBox txt_lunchCount;
        private TextBox txt_dinnercount;
    }
}
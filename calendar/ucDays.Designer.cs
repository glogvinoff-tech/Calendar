namespace SimpleCalendar
{
    partial class ucDays
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDay;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDay.Location = new System.Drawing.Point(5, 5);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(19, 13);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "00";
            
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDay);
            this.Size = new System.Drawing.Size(40, 30);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
namespace SimpleCalendar
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMonthYear;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.FlowLayoutPanel daysPanel;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblSunday;

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
            this.lblMonthYear = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.daysPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblMonthYear
            this.lblMonthYear.AutoSize = true;
            this.lblMonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblMonthYear.Location = new System.Drawing.Point(120, 20);
            this.lblMonthYear.Name = "lblMonthYear";
            this.lblMonthYear.Size = new System.Drawing.Size(140, 24);
            this.lblMonthYear.TabIndex = 0;
            this.lblMonthYear.Text = "Month Year";
            this.lblMonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnPrev
            this.btnPrev.Location = new System.Drawing.Point(20, 20);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 30);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);

            // btnNext
            this.btnNext.Location = new System.Drawing.Point(285, 20);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 30);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            // daysPanel
            this.daysPanel.Location = new System.Drawing.Point(20, 100);
            this.daysPanel.Name = "daysPanel";
            this.daysPanel.Size = new System.Drawing.Size(340, 200);
            this.daysPanel.TabIndex = 3;

            int labelWidth = 48;
            int startX = 20;
            int yPos = 80;

            this.lblMonday.AutoSize = false;
            this.lblMonday.Location = new System.Drawing.Point(startX, yPos);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(labelWidth, 13);
            this.lblMonday.TabIndex = 4;
            this.lblMonday.Text = "Ïí";
            this.lblMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTuesday.AutoSize = false;
            this.lblTuesday.Location = new System.Drawing.Point(startX + labelWidth, yPos);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(labelWidth, 13);
            this.lblTuesday.TabIndex = 5;
            this.lblTuesday.Text = "Âò";
            this.lblTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblWednesday.AutoSize = false;
            this.lblWednesday.Location = new System.Drawing.Point(startX + labelWidth * 2, yPos);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(labelWidth, 13);
            this.lblWednesday.TabIndex = 6;
            this.lblWednesday.Text = "Ñð";
            this.lblWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblThursday.AutoSize = false;
            this.lblThursday.Location = new System.Drawing.Point(startX + labelWidth * 3, yPos);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(labelWidth, 13);
            this.lblThursday.TabIndex = 7;
            this.lblThursday.Text = "×ò";
            this.lblThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblFriday.AutoSize = false;
            this.lblFriday.Location = new System.Drawing.Point(startX + labelWidth * 4, yPos);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(labelWidth, 13);
            this.lblFriday.TabIndex = 8;
            this.lblFriday.Text = "Ïò";
            this.lblFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSaturday.AutoSize = false;
            this.lblSaturday.Location = new System.Drawing.Point(startX + labelWidth * 5, yPos);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(labelWidth, 13);
            this.lblSaturday.TabIndex = 9;
            this.lblSaturday.Text = "Ñá";
            this.lblSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSunday.AutoSize = false;
            this.lblSunday.Location = new System.Drawing.Point(startX + labelWidth * 6, yPos);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(labelWidth, 13);
            this.lblSunday.TabIndex = 10;
            this.lblSunday.Text = "Âñ";
            this.lblSunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 321);
            this.Controls.Add(this.lblSunday);
            this.Controls.Add(this.lblSaturday);
            this.Controls.Add(this.lblFriday);
            this.Controls.Add(this.lblThursday);
            this.Controls.Add(this.lblWednesday);
            this.Controls.Add(this.lblTuesday);
            this.Controls.Add(this.lblMonday);
            this.Controls.Add(this.daysPanel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lblMonthYear);
            this.Name = "Form1";
            this.Text = "Simple Calendar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
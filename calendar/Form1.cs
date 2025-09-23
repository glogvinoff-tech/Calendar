using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalendar
{
    public partial class Form1 : Form
    {
        private DateTime currentDate;

        public Form1()
        {
            InitializeComponent();
            currentDate = DateTime.Now;
            lblMonthYear.Cursor = Cursors.Hand; // Сделать название месяца кликабельным
            lblMonthYear.Click += LblMonthYear_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayCalendar();
        }

        private void DisplayCalendar()
        {
            daysPanel.Controls.Clear();

            var russianCulture = new System.Globalization.CultureInfo("ru-RU");
            lblMonthYear.Text = currentDate.ToString("MMMM yyyy", russianCulture);

            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

            int startDay = (int)firstDayOfMonth.DayOfWeek;
            if (startDay == 0) startDay = 7;
            startDay--;

            for (int i = 0; i < startDay; i++)
            {
                ucDays emptyDay = new ucDays();
                emptyDay.BackColor = Color.LightGray;
                emptyDay.Enabled = false;
                daysPanel.Controls.Add(emptyDay);
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                ucDays dayControl = new ucDays();
                dayControl.Day = day;
                dayControl.Date = new DateTime(currentDate.Year, currentDate.Month, day);

                if (day == DateTime.Now.Day && currentDate.Month == DateTime.Now.Month && currentDate.Year == DateTime.Now.Year)
                {
                    dayControl.BackColor = Color.Yellow;
                }

                daysPanel.Controls.Add(dayControl);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            DisplayCalendar();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            DisplayCalendar();
        }

        private void LblMonthYear_Click(object sender, EventArgs e)
        {
            SelectMonthYear();
        }

        private void SelectMonthYear()
        {
            using (Form selectForm = new Form())
            {
                selectForm.Text = "Выберите месяц и год";
                selectForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                selectForm.Size = new Size(300, 150);
                selectForm.StartPosition = FormStartPosition.CenterParent;
                selectForm.MaximizeBox = false;
                selectForm.MinimizeBox = false;

                ComboBox comboMonth = new ComboBox() { Location = new Point(30, 20), Width = 220, DropDownStyle = ComboBoxStyle.DropDownList };
                var russianCulture = new System.Globalization.CultureInfo("ru-RU");
                for (int i = 1; i <= 12; i++)
                {
                    comboMonth.Items.Add(russianCulture.DateTimeFormat.GetMonthName(i));
                }
                comboMonth.SelectedIndex = currentDate.Month - 1;

                NumericUpDown nudYear = new NumericUpDown()
                {
                    Location = new Point(30, 60),
                    Width = 220,
                    Minimum = 1900,
                    Maximum = 2100,
                    Value = currentDate.Year
                };

                Button btnOk = new Button() { Text = "ОК", Location = new Point(100, 100), Width = 80, DialogResult = DialogResult.OK };

                selectForm.Controls.Add(comboMonth);
                selectForm.Controls.Add(nudYear);
                selectForm.Controls.Add(btnOk);

                selectForm.AcceptButton = btnOk;

                if (selectForm.ShowDialog() == DialogResult.OK)
                {
                    int selectedMonth = comboMonth.SelectedIndex + 1;
                    int selectedYear = (int)nudYear.Value;
                    currentDate = new DateTime(selectedYear, selectedMonth, 1);
                    DisplayCalendar();
                }
            }
        }
    }
}
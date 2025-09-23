using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalendar
{
    public partial class NoteForm : Form
    {
        private TextBox textBox;
        private Button btnSave;
        private Button btnCancel;
        private Label lblDate;

        public NoteForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Заметка";
            this.Size = new Size(300, 200);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Date Label
            this.lblDate = new Label();
            this.lblDate.Location = new Point(10, 10);
            this.lblDate.Size = new Size(280, 20);
            this.lblDate.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            this.Controls.Add(lblDate);

            // TextBox
            this.textBox = new TextBox();
            this.textBox.Location = new Point(10, 35);
            this.textBox.Size = new Size(265, 80);
            this.textBox.Multiline = true;
            this.textBox.ScrollBars = ScrollBars.Vertical;
            this.Controls.Add(textBox);

            // Save Button
            this.btnSave = new Button();
            this.btnSave.Location = new Point(120, 130);
            this.btnSave.Size = new Size(75, 25);
            this.btnSave.Text = "Сохранить";
            this.btnSave.DialogResult = DialogResult.OK;
            this.btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            // Cancel Button
            this.btnCancel = new Button();
            this.btnCancel.Location = new Point(200, 130);
            this.btnCancel.Size = new Size(75, 25);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.DialogResult = DialogResult.Cancel;
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        public DateTime Date
        {
            set { lblDate.Text = value.ToString("dd.MM.yyyy"); }
        }

        public string NoteText
        {
            get { return textBox.Text.Trim(); }
            set { textBox.Text = value; }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
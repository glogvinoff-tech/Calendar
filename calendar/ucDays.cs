using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalendar
{
    public partial class ucDays : UserControl
    {
        private DateTime date = DateTime.MinValue;
        private Label dayLabel;
        private PictureBox noteIndicator;
        private int day;

        public ucDays()
        {
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.dayLabel = new Label();
            this.dayLabel.Dock = DockStyle.Fill;
            this.dayLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.dayLabel.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            this.dayLabel.Click += UcDays_Click;

            this.noteIndicator = new PictureBox();
            this.noteIndicator.Size = new Size(8, 8);
            this.noteIndicator.Location = new Point(2, 2);
            this.noteIndicator.BackColor = Color.Red;
            this.noteIndicator.Visible = false;
            this.noteIndicator.Click += UcDays_Click;

            this.Size = new Size(40, 40);
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(dayLabel);
            this.Controls.Add(noteIndicator);
            this.Click += UcDays_Click;
        }

        public int Day
        {
            get { return day; }
            set
            {
                day = value;
                if (dayLabel != null && !dayLabel.IsDisposed)
                {
                    dayLabel.Text = day.ToString();
                }
                UpdateNoteIndicator();
            }
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                UpdateNoteIndicator();
            }
        }

        private void UpdateNoteIndicator()
        {
            if (date != DateTime.MinValue && noteIndicator != null && !noteIndicator.IsDisposed)
            {
                try
                {
                    noteIndicator.Visible = NotesManager.HasNote(date);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"UpdateNoteIndicator error: {ex.Message}");
                    noteIndicator.Visible = false;
                }
            }
        }

        private void UcDays_Click(object sender, EventArgs e)
        {
            if (date != DateTime.MinValue)
            {
                ShowNoteDialog();
            }
        }

        private void ShowNoteDialog()
        {
            if (date == DateTime.MinValue) return;

            try
            {
                string currentNote = NotesManager.GetNote(date);

                using (NoteForm noteForm = new NoteForm())
                {
                    noteForm.Date = date;
                    noteForm.NoteText = currentNote;

                    if (noteForm.ShowDialog() == DialogResult.OK)
                    {
                        if (string.IsNullOrEmpty(noteForm.NoteText))
                        {
                            NotesManager.DeleteNote(date);
                        }
                        else
                        {
                            NotesManager.AddNote(date, noteForm.NoteText);
                        }
                        UpdateNoteIndicator();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии заметки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isDialogOpen = false;

        protected override void OnClick(EventArgs e)
        {
            if (!isDialogOpen && date != DateTime.MinValue)
            {
                isDialogOpen = true;
                try
                {
                    ShowNoteDialog();
                }
                finally
                {
                    isDialogOpen = false;
                }
            }
            base.OnClick(e);
        }
    }
}
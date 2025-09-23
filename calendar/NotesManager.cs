using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SimpleCalendar
{
    public class Note
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }

    public static class NotesManager
    {
        private static List<Note> notes = new List<Note>();
        private static string filePath = "notes.txt";

        static NotesManager()
        {
            LoadNotes();
        }

        public static void AddNote(DateTime date, string text)
        {
            var existingNote = notes.FirstOrDefault(n => n.Date.Date == date.Date);
            if (existingNote != null)
            {
                existingNote.Text = text;
            }
            else
            {
                notes.Add(new Note { Date = date, Text = text });
            }
            SaveNotes();
        }

        public static string GetNote(DateTime date)
        {
            var note = notes.FirstOrDefault(n => n.Date.Date == date.Date);
            return note?.Text ?? "";
        }

        public static bool HasNote(DateTime date)
        {
            return notes.Any(n => n.Date.Date == date.Date);
        }

        public static void DeleteNote(DateTime date)
        {
            var note = notes.FirstOrDefault(n => n.Date.Date == date.Date);
            if (note != null)
            {
                notes.Remove(note);
                SaveNotes();
            }
        }

        private static void SaveNotes()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    foreach (var note in notes)
                    {
                        // Экранируем переносы строк и разделители
                        string safeText = note.Text.Replace("|", "&#124;")
                                                  .Replace("\r\n", "&#13;")
                                                  .Replace("\n", "&#10;");
                        writer.WriteLine($"{note.Date:yyyy-MM-dd}|{safeText}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения заметок: {ex.Message}");
            }
        }

        private static void LoadNotes()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    notes.Clear();
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        string[] parts = line.Split('|');
                        if (parts.Length >= 2 && DateTime.TryParse(parts[0], out DateTime date))
                        {
                            // Восстанавливаем текст
                            string text = parts[1];
                            if (parts.Length > 2)
                            {
                                // Если есть дополнительные части (из-за | в тексте), объединяем их
                                text = string.Join("|", parts.Skip(1));
                            }

                            // Восстанавливаем экранированные символы
                            text = text.Replace("&#124;", "|")
                                      .Replace("&#13;", "\r\n")
                                      .Replace("&#10;", "\n");

                            notes.Add(new Note { Date = date, Text = text });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заметок: {ex.Message}");
            }
        }
    }
}
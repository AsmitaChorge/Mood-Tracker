using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SentimentAnalyzerApp
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            LoadMoodHistory();
        }

        private void LoadMoodHistory()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var entry in MoodStorage.Entries)
            {
                var panel = new Panel()
                {
                    Width = 250,
                    Height = 120,
                    BackColor = System.Drawing.Color.FromArgb(30, 30, 30),
                    Padding = new Padding(10),
                    Margin = new Padding(10)
                };

                var lblText = new Label() { Text = $"\"{entry.Text}\"", ForeColor = System.Drawing.Color.White, AutoSize = true };
                var lblSentiment = new Label() { Text = $"Result: {entry.Sentiment}", ForeColor = System.Drawing.Color.Yellow, AutoSize = true };

                var btnDelete = new Button() { Text = "Delete", BackColor = System.Drawing.Color.White };
                btnDelete.Click += (s, e) =>
                {
                    MoodStorage.Entries.Remove(entry);
                    LoadMoodHistory();
                };

                panel.Controls.Add(lblText);
                panel.Controls.Add(lblSentiment);
                panel.Controls.Add(btnDelete);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AnalyzeForm af = new AnalyzeForm();
            af.Show();
            this.Hide();
        }
    }
}

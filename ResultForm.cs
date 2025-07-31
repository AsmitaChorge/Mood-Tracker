using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SentimentAnalyzerApp
{
    

    public partial class ResultForm : Form
    {
        private static List<MoodEntry> moodEntries = new List<MoodEntry>();

        private string userInput;
        private string sentiment;

        public ResultForm(string input, string sentiment)
        {
            InitializeComponent(); // Always call this first

            this.userInput = input;
            this.sentiment = sentiment;

            
            lblResult.Text = sentiment;

            // Optional: Color-code result
            if (sentiment.Contains("Positive"))
                lblResult.ForeColor = Color.Green;
            else if (sentiment.Contains("Negative"))
                lblResult.ForeColor = Color.Red;
            else
                lblResult.ForeColor = Color.Gray;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            // Additional setup if needed
        }

        private void btnAnalyzeAnother_Click(object sender, EventArgs e)
        {
            AnalyzeForm analyzeForm = new AnalyzeForm();
            analyzeForm.Show();
            this.Hide();
        }

        private void saveMH_Click(object sender, EventArgs e)
        {
            MoodStorage.AddEntry(new MoodEntry { Text = userInput, Sentiment = sentiment });
            HistoryForm hf = new HistoryForm();
            hf.Show();
            this.Hide();
        }
    }
}

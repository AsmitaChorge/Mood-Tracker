using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SentimentAnalyzerApp
{
    public partial class AnalyzeForm : Form
    {
        public AnalyzeForm()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {

            {
                string userInput = txtInput.Text.Trim();
                // Check if input is empty  
                if (string.IsNullOrEmpty(userInput))
                {
                    MessageBox.Show("Please enter some text first.");
                    return;
                }


                // Sample positive and negative word lists
                string[] positiveWords = { "happy", "good", "great", "awesome", "love", "excellent", "nice", "fantastic", "joy", "wonderful" };
                string[] negativeWords = { "sad", "bad", "terrible", "hate", "angry", "poor", "worst", "awful", "depressing", "disappointed" };


                // Get user input and convert to lowercase Split input into words
                string input = txtInput.Text.ToLower();
    
                string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);

                int positiveCount = 0;
                int negativeCount = 0;

                // Count how many positive or negative words are in input
                foreach (string word in words)
                {
                    if (positiveWords.Contains(word))
                        positiveCount++;
                    else if (negativeWords.Contains(word))
                        negativeCount++;
                }

                // Determine sentiment
                string sentiment;
                if (positiveCount > negativeCount)
                    sentiment = "Positive 😊";
                else if (negativeCount > positiveCount)
                    sentiment = "Negative 😞";
                else
                    sentiment = "Neutral 😐";

           

                // Optionally: Pass result to ResultForm
                ResultForm rf = new ResultForm(txtInput.Text, sentiment);
                rf.Show();
                this.Hide();
            }

        }
    }
}


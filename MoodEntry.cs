using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalyzerApp
{
    public class MoodEntry
    {
        public string Text { get; set; }
        public string Sentiment { get; set; }

        public MoodEntry() { }

        public MoodEntry(string text, string sentiment)
        {
            Text = text;
            Sentiment = sentiment;
        }
    }
}



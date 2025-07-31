using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalyzerApp
{
    public static class MoodStorage
    {
        public static List<MoodEntry> Entries { get; private set; } = new List<MoodEntry>();

        public static void AddEntry(MoodEntry entry)
        {
            Entries.Add(entry);
        }
    }
}

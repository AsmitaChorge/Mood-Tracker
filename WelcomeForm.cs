using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentimentAnalyzerApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent(); // Required to load the form UI
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            // Move to the next screen: AnalyzeForm
            AnalyzeForm analyzeForm = new AnalyzeForm();
            analyzeForm.Show();   // opens the next form
            this.Hide();          // hides the current form
        }
    }
}

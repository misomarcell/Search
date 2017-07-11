using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Matcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matchList.Items.Clear();
            if ( txtPattern.Text != "" && richInput.Text != "" )
            {
                Search(txtPattern.Text);
            }
        }

        private void Search(string pattern)
        {
            MatchCollection collection = Regex.Matches(richInput.Text, pattern);

            foreach ( Match match in collection )
            {
                matchList.Items.Add(match.Value);
            }
        }
    }
}

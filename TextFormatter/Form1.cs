using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFormatter
{
    public partial class Form1 : Form
    {   
        public string inputText = String.Empty;
        public string patternA = @"\b\d{16,}\b";
        List<string> strings = new List<string>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputText = textBox1.Text;
            MatchCollection matches = Regex.Matches(inputText, patternA);
            Label users = new Label();
            users.Text = "Users";
            Label count = new Label();
            count.Text = "Count";
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.Controls.Add(users, 0, 0);
            tableLayoutPanel1.Controls.Add(count, 1, 0);

            foreach (Match match in matches)
            {
                
                
                
                strings.Add(match.Value);
               
               
                                
            }
            
            tableLayoutPanel1.RowCount = strings.Count + 1;
            List<string> listofusers = new List<string>();
            listofusers = strings.Where(x => x.);

        }
    }
}

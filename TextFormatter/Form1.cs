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
        List<User> users = new List<User>();
        User user = new User();
        List<string> listofusers = new List<string>();
        List<string> strings = new List<string>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputText = textBox1.Text;
            MatchCollection matches = Regex.Matches(inputText, patternA);
        

            foreach (Match match in matches)
            {              
                strings.Add(match.Value);                                     
            }
            var countByValue = strings
             .GroupBy(item => item)
             .Select(group => new { Value = group.Key, Count = group.Count() })
             .ToList();




            foreach (var element in countByValue)
            {
                user = new User();
                user.Id = element.Value;
                user.count = element.Count;
                users.Add(user);
              
            }
            var listAsc = users.OrderByDescending(x => x.count);
            foreach (var element in listAsc)
            {
                listofusers.Add(element.Id + " : " + element.count);
            }
            foreach (var element in listofusers)
            {
                listView1.Items.Add(element);   
            }





        }
    }
}

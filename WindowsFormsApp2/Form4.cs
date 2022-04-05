using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        Team[] teams = new Team[5];
        public Form4()
        {
            InitializeComponent();
            Team team = new Team();
            teams[0] = new Team();
            teams[0].Set("1", "Miami Heat", "MIA", "1.jpg");

            teams[1] = new Team();
            teams[1].Set("2", "Orlando Magic", "ORL", "2.jpg");

            teams[2] = new Team();
            teams[2].Set("3", "Atlanta Hawks", "ATL", "3.jpg");

            teams[3] = new Team();
            teams[3].Set("4", "Washington Wizards", "WSH", "4.jpg");

            teams[4] = new Team();
            teams[4].Set("5", "Charlotte Hornets", "CHA", "5.jpg");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lab1.Text = teams[0].Name;
            Controls["lab" + 1].Text = teams[0].Name;
            lab2.Text = teams[1].Name;
            Controls["lab" + 2].Text = teams[1].Name;
            lab3.Text = teams[2].Name;
            Controls["lab" + 3].Text = teams[2].Name;
            lab4.Text = teams[3].Name;
            Controls["lab" + 4].Text = teams[3].Name;
            lab5.Text = teams[4].Name;
            Controls["lab" + 5].Text = teams[4].Name;

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }
    }
}

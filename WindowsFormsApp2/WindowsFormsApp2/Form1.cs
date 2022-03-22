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
    public partial class Form1 : Form
    {
        String[] imgList = new String[]
               { "1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg"};
        int index = 0;
        // ImgList
        Country[] countries = new Country[5];

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Load("../../../Pictures/" + imgList[0]);
            pictureBox3.Load("../../../Pictures/" + imgList[1]);
            pictureBox4.Load("../../../Pictures/" + imgList[2]);

            Country country = new Country();

            country.Set("ARG", "Argentina");
            countries[0] = country;

            country.Set("AT", "Austria");
            countries[1] = country;

            country.Set("AUS", "Australia);
            countries[2] = country;

            country.Set("BI", "Bosnia");
            countries[3] = country;

            country.Set("BR", "Brazil");
            countries[4] = country;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index + 3 > imgList.Length) index = 0;
            pictureBox1.Load("../../../Pictures/" + imgList[index + 0]);
            pictureBox3.Load("../../../Pictures/" + imgList[index + 1]);
            pictureBox4.Load("../../../Pictures/" + imgList[index + 2]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = index - 1;
            if (index < 0) index = imgList.Length - 3;
            pictureBox1.Load("../../../Pictures/" + imgList[index + 0]);
            pictureBox3.Load("../../../Pictures/" + imgList[index + 1]);
            pictureBox4.Load("../../../Pictures/" + imgList[index + 2]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            Hide();
        }
    }
}
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
        Player[] players = new Player[5];
        
        PositionName[] positionNames = new PositionName[5];
        PositionOfPlayer[] positionOfPlayers = new PositionOfPlayer[5];

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Load("../../../Pictures/" + imgList[0]);
            pictureBox3.Load("../../../Pictures/" + imgList[1]);
            pictureBox4.Load("../../../Pictures/" + imgList[2]);

            Country country = new Country();

            country.Set("ARG","Argentina");
            countries[0] = country;

            country.Set("AT","Austria");
            countries[1] = country;

            country.Set("AUS", "Australia");

            country.Set("BI","Bosnia");
            countries[3] = country;

            country.Set("BR","Brazil");
            countries[4] = country;

            Player player = new Player();
            player.Set("1", "Mo", "Williams", "1,85", "89,8", "US");
            players[0] = player;

            player.Set("2", "Alonzo", "Edward Gee", "1,98", "99", "US");
            players[1] = player;


            player.Set("3", "Johnny ", "O'Bryant", "2,05", "116,5", "US");
            players[2] = player;

            player.Set("4", "Danilo", "Gallinari", "2,08", "102", "US");
            players[3] = player;

            player.Set("5", "Darrell ", "Arthur", "2,06", "107", "US");
            players[4] = player;

            

            PositionName positionName = new PositionName();
            positionName.Set("1", "SmallForward");
            positionNames[0] = positionName;

            positionName.Set("2", "PowerForward");
            positionNames[1] = positionName;

            positionName.Set("3", "Center");
            positionNames[2] = positionName;

            positionName.Set("4", "ShootingGuard");
            positionNames[3] = positionName;

            positionName.Set("5", "PointGuard");
            positionNames[4] = positionName;

            PositionOfPlayer positionOfPlayer = new PositionOfPlayer();
            positionOfPlayer.Set("1", "1");
            positionOfPlayers[0] = positionOfPlayer;

            positionOfPlayer.Set("2", "2");
            positionOfPlayers[1] = positionOfPlayer;

            positionOfPlayer.Set("3", "3");
            positionOfPlayers[2] = positionOfPlayer;

            positionOfPlayer.Set("4", "4");
            positionOfPlayers[3] = positionOfPlayer;

            positionOfPlayer.Set("5", "5");
            positionOfPlayers[4] = positionOfPlayer;



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
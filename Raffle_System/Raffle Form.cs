using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raffle_System
{
    public partial class RaffleAddu : Form
    {
        public List<string> eventRow; // Getting the rows for Event
        List<List<string>> data; //data on who's in event

        DatabaseConnect connect; // for class database
        // Timer
        Boolean running = false;// Timer
        Random rand;
        int index;

        System.Media.SoundPlayer player;// Music
        public RaffleAddu()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(200, panel1.BackColor);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rand = new Random();
            index = rand.Next(data.Count);
            var num = data[index][0];
            lblRandom.Text = num;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new DatabaseConnect();
            data = connect.AdduAttendanceData(eventRow[4].ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRaffleStart_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (running == false)
            {
                //Music plays
                player = new System.Media.SoundPlayer("gg1.wav");
                player.Play();

                timeRandom.Start();
                running = true;
                btnRaffleStart.Text = "Stop";
            }
            else if (running == true)
            {
                player.Stop();
                var completeName = data[index][2] + ", " + data[index][1];
                lblRandName.Text = completeName;
                timeRandom.Stop();
                running = false;
                btnRaffleStart.Text = "Start";
                data.RemoveAt(index);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mfInitialize = new MainForm();
            mfInitialize.Show();
            this.Close();
        }
    }
}

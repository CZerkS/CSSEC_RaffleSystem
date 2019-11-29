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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DatabaseConnect connect;
        List<List<string>> eventData;
        private void MainForm_Load(object sender, EventArgs e)
        {
            connect = new DatabaseConnect();
            eventData = connect.EventData();

            for (int i = 0; i < eventData.Count; i++)
                cmbEvents.Items.Add(eventData[i][1]);
        }

        int eid;
        private void cmbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string eventChosen = cmbEvents.Text;
            lblEventName.Text = eventChosen;

            for (int i = 0; i < eventData.Count; i++)
            {
                if(eventData[i][1] == eventChosen)
                {
                    eid = i;
                }
            }
        }

        private void btnEventRaffle_Click(object sender, EventArgs e)
        {
            if(cmbEvents.Text != "")
            {
                RaffleAddu rsInitialize = new RaffleAddu();
                rsInitialize.eventRow = new List<string>() {eventData[eid][0], eventData[eid][1],
                eventData[eid][2], eventData[eid][3], eventData[eid][4], eventData[eid][5]};
                rsInitialize.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No Event/s available", "NO EVENTS");
            }
            
        }

        private void btnGuestRaffle_Click(object sender, EventArgs e)
        {
            if (cmbEvents.Text != "")
            {
                RaffleGuestForm rgfInitialize = new RaffleGuestForm();
                rgfInitialize.eventRow = new List<string>() {eventData[eid][0], eventData[eid][1],
                eventData[eid][2], eventData[eid][3], eventData[eid][4], eventData[eid][5]};
                rgfInitialize.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No Event/s available", "NO EVENTS");
            }
        }
    }
}

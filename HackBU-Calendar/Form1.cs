using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackBU_Calendar
{
    public partial class Form1 : Form
    {
        string[] name;
        string[] loc;
        DateTime[] startTime;
        DateTime[] endTime;
        bool[,] dow;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumEvent_ValueChanged(object sender, EventArgs e)
        {

            //Initialize and set all variables
            name = new string[(int)(numEvent.Value)];
            loc = new string[(int)(numEvent.Value)];
            dow = new bool[(int)(numEvent.Value) , chkDates.Items.Count];
            startTime = new DateTime[(int)numEvent.Value];
            endTime = new DateTime[(int)numEvent.Value];

            for(int i = 0; i < numEvent.Value; i++)
            {
                name[i] = "";
                loc[i] = "";
                for(int j = 0; j < chkDates.Items.Count; j++)
                {
                    dow[i, j] = false;
                }
            }

            pickedEvent.ResetText();
            pickedEvent.Items.Clear();

            for(int i = 1; i <= numEvent.Value; i++)
            {
                pickedEvent.Items.Add(i);
            }

            if (pickedEvent.Items.Count != 0)
            {
                pickedEvent.SelectedIndex = 0;
            }
        }

        private void TxtNam_TextChanged(object sender, EventArgs e)
        {
            name[pickedEvent.SelectedIndex] = txtNam.Text;
        }

        private void TxtLoc_TextChanged(object sender, EventArgs e)
        {
            loc[pickedEvent.SelectedIndex] = txtLoc.Text;
        }

        private void TimStart_ValueChanged(object sender, EventArgs e)
        {
            startTime[pickedEvent.SelectedIndex] = timStart.Value;
        }

        private void TimEnd_ValueChanged(object sender, EventArgs e)
        {
            startTime[pickedEvent.SelectedIndex] = timEnd.Value;
        }

        private void PickedEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

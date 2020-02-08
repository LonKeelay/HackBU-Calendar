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
        bool[,] dow;


        public Form1()
        {
            InitializeComponent();
        }

        private void NumEvent_ValueChanged(object sender, EventArgs e)
        {
            name = new string[(int)(numEvent.Value)];
            loc = new string[(int)(numEvent.Value)];
            dow = new bool[(int)(numEvent.Value) , chkDates.Items.Count];

            pickedEvent.ResetText();
            pickedEvent.Items.Clear();
            for(int i = 1; i <= numEvent.Value; i++)
            {
                pickedEvent.Items.Add(i);
            }
        }
    }
}

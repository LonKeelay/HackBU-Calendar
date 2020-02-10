using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;

namespace HackBU_Calendar
{
    public partial class Form1 : Form
    {
        
        string[] name;
        string[] loc;
        DateTime[] startTime;
        DateTime[] endTime;
        bool[,] dow;
        Occasion[] events;
        int[] colorPicked;
        int[] colorIndex;

        DataPoint[,] datas;

        int prevClasses;

        bool inits;

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            name.Add("");
            loc;
            startTime[0] = datStart.MinDate;
            endTime[0] = datEnd.MinDate;
            bool[] oof = new bool[chkDates.Items.Count];
            for(int i = 0; i < chkDates.Items.Count; i++)
            {
                oof[i] = false;
            }
            dow[0] = oof;
            */
            txtNam.Enabled = false;
            txtLoc.Enabled = false;
            chkDates.Enabled = false;
            timStart.Enabled = false;
            timEnd.Enabled = false;
            pickedEvent.Enabled = false;
            initChart();
            string[] colors = { "Teal", "Purple", "Pink", "Yellow", "Orange", "Blue", "Gray", "Green", "Red" };
            foreach(string color in colors)
            {
                colorPick.Items.Add(color);
            }
            inits = false;
            prevClasses = 0;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void NumEvent_ValueChanged(object sender, EventArgs e)
        {
            /* 
             * Logan's thinking:
             * if 1 more class, add the others to a new array and cast it over
             * 
             * So:
             *  create new array
             *  if class added:
             *      if zero, skip everything until last part
             *      otherwise:
             *          add all objects from previous array to same index
             *      add last index with default values
             *  if class subtracted:
             *      add all objects from previous array to same index
             */
            string[] name1 = new string[(int)(numEvent.Value)];
            string[] loc1 = new string[(int)(numEvent.Value)];
            bool[,]dow1 = new bool[(int)(numEvent.Value), chkDates.Items.Count];
            DateTime[] startTime1 = new DateTime[(int)numEvent.Value];
            DateTime[] endTime1 = new DateTime[(int)numEvent.Value];
            DataPoint[,] datas1 = new DataPoint[(int)numEvent.Value, chkDates.Items.Count];
            int[] colorPicked1 = new int[(int)numEvent.Value];
            int[] colorIndex1 = new int[(int)numEvent.Value];
            Occasion[] events1 = new Occasion[(int)numEvent.Value];

            if (numEvent.Value > prevClasses)
            {
                if (prevClasses > 0)
                {
                    for (int i = 0; i < prevClasses; i++)
                    {
                        name1[i] = name[i];
                        loc1[i] = loc[i];
                        startTime1[i] = startTime[i];
                        endTime1[i] = endTime[i];
                        colorPicked1[i] = colorPicked[i];
                        colorIndex1[i] = colorIndex[i];
                        events1[i] = events[i];
                        for (int j = 0; j < chkDates.Items.Count; j++)
                        {
                            dow1[i, j] = dow[i, j];
                            datas1[i, j] = datas[i, j];
                        }
                    }
                }
                else
                {
                    prevClasses = 0;
                }
                colorIndex1[prevClasses] = 5;
                colorPicked1[prevClasses] = 7;
                name1[prevClasses] = "";
                loc1[prevClasses] = "";
                events1[prevClasses] = new Occasion();
                for (int j = 0; j < chkDates.Items.Count; j++)
                {
                    dow1[prevClasses, j] = false;
                    datas1[prevClasses, j] = new DataPoint();
                }
                /*
                startTime[prevClasses] = new DateTime(DateTime.MinValue.Ticks);
                startTime[prevClasses] = timStart.MinDate;
                endTime[prevClasses] = new DateTime(DateTime.MinValue.Ticks);
                endTime[prevClasses] = timEnd.MinDate;
                */

                prevClasses++;
                pickedEvent.Items.Add(prevClasses);
                if(prevClasses == 1)
                {
                    pickedEvent.SelectedIndex = 0;
                }
            }
            else if (numEvent.Value < prevClasses)
            {
                if (prevClasses > 1)
                {
                    for (int i = 0; i < numEvent.Value; i++)
                    {
                        name1[i] = name[i];
                        loc1[i] = loc[i];
                        startTime1[i] = startTime[i];
                        endTime1[i] = endTime[i];
                        colorPicked1[i] = colorPicked[i];
                        colorIndex1[i] = colorIndex[i];
                        events1[i] = events[i];
                        for (int j = 0; j < chkDates.Items.Count; j++)
                        {
                            dow1[i, j] = dow[i, j];
                            datas1[i, j] = datas[i, j];
                        }
                    }
                }
                pickedEvent.Items.Remove(prevClasses);
                prevClasses--;
                if (prevClasses > 0)
                {
                    pickedEvent.SelectedIndex = prevClasses - 1;
                }
            }
            name = new string[(int)(numEvent.Value)];
            loc = new string[(int)(numEvent.Value)];
            dow = new bool[(int)(numEvent.Value), chkDates.Items.Count];
            startTime = new DateTime[(int)numEvent.Value];
            endTime = new DateTime[(int)numEvent.Value];
            datas = new DataPoint[(int)numEvent.Value, chkDates.Items.Count];
            colorPicked = new int[(int)numEvent.Value];
            colorIndex = new int[(int)numEvent.Value];
            events = new Occasion[(int)numEvent.Value];

            name = name1;
            loc = loc1;
            dow = dow1;
            startTime = startTime1;
            endTime = endTime1;
            datas = datas1;
            colorPicked = colorPicked1;
            colorIndex = colorIndex1;
            events = events1;

            txtLoc.Text = loc[pickedEvent.SelectedIndex];
            txtNam.Text = name[pickedEvent.SelectedIndex];

            //Prevent user from modifying anything if the amount of classes is 0
            if (numEvent.Value == 0)
            {
                txtNam.Enabled = false;
                txtLoc.Enabled = false;
                chkDates.Enabled = false;
                timStart.Enabled = false;
                timEnd.Enabled = false;
                pickedEvent.Enabled = false;
                pickedEvent.Text = "";
                colorPick.Enabled = false;
                return;
            }
            else
            {
                txtNam.Enabled = true;
                txtLoc.Enabled = true;
                chkDates.Enabled = true;
                timStart.Enabled = true;
                timEnd.Enabled = true;
                pickedEvent.Enabled = true;
                colorPick.Enabled = true;
            }

            initChart();
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
            endTime[pickedEvent.SelectedIndex] = timEnd.Value;
        }

        private void PickedEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLoc.Text = loc[pickedEvent.SelectedIndex].ToString();
            txtNam.Text = name[pickedEvent.SelectedIndex].ToString();
            timStart.Value = startTime[pickedEvent.SelectedIndex];
            timEnd.Value = endTime[pickedEvent.SelectedIndex];
            colorPick.SelectedIndex = colorIndex[pickedEvent.SelectedIndex];
            for (int i = 0; i < chkDates.Items.Count; i++)
            {
                chkDates.SetItemChecked(i, false);
                if (dow[pickedEvent.SelectedIndex,i])
                {
                    chkDates.SetItemChecked(i, true);
                }
            }
            
        }

        private void ChkDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool[] oof = new bool[chkDates.Items.Count];
            for(int i = 0; i < chkDates.Items.Count; i++)
            {
                dow[pickedEvent.SelectedIndex,i] = chkDates.GetItemChecked(i);
            }
            updateCharts();
        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            updateEvent();
            //Check for any user error (thanks Logan)
            bool noWeek = false;
            bool noName = false;
            for (int i = 0; i < events.Length; i++)
            {
                if (!noWeek)
                {
                    //Checks each week (i) to see if there is one with all false on their days (j)
                    int wkTest = 0;
                    for(int j = 0; j < chkDates.Items.Count; j++)
                    {
                        if (dow[i, j])
                        {
                            wkTest++;
                        }
                    }
                    if(wkTest == 0) { noWeek = true; }
                }

                if (!noName)
                {
                    //noName turns true if there is nothing in name
                    noName = name[i].Length == 0;
                }
            }
            if (noWeek || noName)
            {
                MessageBox.Show("One or more of the fields are blank!");
                return;
            }

            for (int i = 0; i < events.Length; i++)
            {
                events[i].setSemStart(datStart.Value);
                events[i].setSemEnd(datEnd.Value);
                events[i].insertEvent();
            }
            MessageBox.Show(events.Length.ToString() + " event(s) created!");
        }

        private void updateEvent()
        {
            for (int i = 0; i < numEvent.Value; i++)
            {

                bool[] test = new bool[chkDates.Items.Count];
                for (int j = 0; j < chkDates.Items.Count; j++)
                {
                    test[j] = dow[i, j];
                }

                events[i].setName(name[i].ToString());
                events[i].setLocation(loc[i].ToString());
                events[i].setDay(test);
                events[i].setStartTime((DateTime)startTime[i]);
                events[i].setEndTime((DateTime)endTime[i]);
                Console.WriteLine(events[i].getRRule());
                events[i].setColor(colorPicked[i]);
            }
        }

        public void initChart()
        {
            deChart.Series.Clear();
            deChart.ChartAreas.Clear();
            deChart.ChartAreas.Add("1");
            deChart.Legends.Clear();
            
            deChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            deChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            deChart.ChartAreas[0].AxisX.Minimum = 0;
            deChart.ChartAreas[0].AxisY.Minimum = 0;
            deChart.ChartAreas[0].AxisX.Maximum = 8;
            deChart.ChartAreas[0].AxisY.Maximum = 24;
            
            
            string[] labels = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            double star = .5;
            double en = 1.5;
            foreach (string lbl in labels)
            {
                CustomLabel monthLabel = new CustomLabel(star, en, lbl, 0, LabelMarkStyle.None);
                deChart.ChartAreas[0].AxisX.CustomLabels.Add(monthLabel);
                star += 1;
                en += 1;
            }

            string[] times = { "12 AM", "2 AM", "4 AM", "6 AM", "8 AM", "10 AM", "12 PM", "2 PM", "4 PM", "6 PM", "8 PM", "10 PM", "12 AM" };
            double to = 24.5;
            double bo = 23.5;
            foreach (string time in times)
            {
                CustomLabel timeLabel = new CustomLabel(to, bo, time, 0, LabelMarkStyle.None);
                deChart.ChartAreas[0].AxisY.CustomLabels.Add(timeLabel);
                to -= 2;
                bo -= 2;
            }

            Series series2 = new Series();
            for (int i = 0; i < numEvent.Value; i++)
            {
                for (int j = 0; j<chkDates.Items.Count; j++)
                {
                    datas[i, j] = new DataPoint();
                    if (j == 6)
                    {
                        datas[i, j].XValue = 1;
                    }
                    else
                    {
                        datas[i, j].XValue = j + 2;
                    }
                    series2.Points.Add(datas[i, j]);
                }
                
            }
            series2.YValuesPerPoint = 2;
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;

            deChart.Series.Add(series2);
            inits = true;
            updateCharts();
        }

        public void updateCharts()
        {
            if (!inits)
            {
                return;
            }
            for (int i = 0; i < numEvent.Value; i++)
            {
                for(int j = 0; j<chkDates.Items.Count; j++)
                {
                    if (dow[i, j])
                    {
                        double[] yes = { -(startTime[i].Hour + startTime[i].Minute / 60.0)+24, -(endTime[i].Hour + startTime[i].Minute / 60.0)+24 };
                        datas[i, j].YValues = yes;

                        Color logan;
                        switch (colorIndex[i])
                        {
                            case 0:
                                logan = Color.Teal;
                                break;
                            case 1:
                                logan = Color.Purple;
                                break;
                            case 2:
                                logan = Color.Pink;
                                break;
                            case 3:
                                logan = Color.Yellow;
                                break;
                            case 4:
                                logan = Color.Orange;
                                break;
                            case 5:
                                logan = Color.Blue;
                                break;
                            case 6:
                                logan = Color.Gray;
                                break;
                            case 7:
                                logan = Color.Green;
                                break;
                            case 8:
                                logan = Color.Red;
                                break;
                            default:
                                logan = Color.Blue;
                                break;
                        }
                        datas[i, j].Color = logan;
                    }
                    else
                    {
                        if(datas[i,j] == null)
                        {
                            datas[i, j] = new DataPoint();
                        }
                        datas[i, j].YValues = null;
                    }
                }
            }
        }

        private void ColorPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorIndex[pickedEvent.SelectedIndex] = colorPick.SelectedIndex;
            switch (colorPick.SelectedIndex)
            {
                case 0:
                    colorPicked[pickedEvent.SelectedIndex] = 2;
                    break;
                case 1:
                    colorPicked[pickedEvent.SelectedIndex] = 3;
                    break;
                case 2:
                    colorPicked[pickedEvent.SelectedIndex] = 4;
                    break;
                case 3:
                    colorPicked[pickedEvent.SelectedIndex] = 5;
                    break;
                case 4:
                    colorPicked[pickedEvent.SelectedIndex] = 6;
                    break;
                case 5:
                    colorPicked[pickedEvent.SelectedIndex] = 7;
                    break;
                case 6:
                    colorPicked[pickedEvent.SelectedIndex] = 8;
                    break;
                case 7:
                    colorPicked[pickedEvent.SelectedIndex] = 10;
                    break;
                case 8:
                    colorPicked[pickedEvent.SelectedIndex] = 11;
                    break;

            }
            updateCharts();
        }
    }
}

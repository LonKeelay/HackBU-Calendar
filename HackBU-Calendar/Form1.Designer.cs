namespace HackBU_Calendar
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datStart = new System.Windows.Forms.DateTimePicker();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numEvent = new System.Windows.Forms.NumericUpDown();
            this.pickedEvent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkDates = new System.Windows.Forms.CheckedListBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.timStart = new System.Windows.Forms.DateTimePicker();
            this.timEnd = new System.Windows.Forms.DateTimePicker();
            this.btnDoIt = new System.Windows.Forms.Button();
            this.deChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.colorPick = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semester Start:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semester End:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datStart
            // 
            this.datStart.CustomFormat = "M/d/yyyy";
            this.datStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datStart.Location = new System.Drawing.Point(99, 12);
            this.datStart.Name = "datStart";
            this.datStart.Size = new System.Drawing.Size(79, 20);
            this.datStart.TabIndex = 2;
            // 
            // datEnd
            // 
            this.datEnd.CustomFormat = "M/d/yyyy";
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datEnd.Location = new System.Drawing.Point(99, 38);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(79, 20);
            this.datEnd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Classes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Class #:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numEvent
            // 
            this.numEvent.Location = new System.Drawing.Point(118, 76);
            this.numEvent.Name = "numEvent";
            this.numEvent.Size = new System.Drawing.Size(60, 20);
            this.numEvent.TabIndex = 6;
            this.numEvent.ValueChanged += new System.EventHandler(this.NumEvent_ValueChanged);
            // 
            // pickedEvent
            // 
            this.pickedEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickedEvent.FormattingEnabled = true;
            this.pickedEvent.Location = new System.Drawing.Point(71, 102);
            this.pickedEvent.Name = "pickedEvent";
            this.pickedEvent.Size = new System.Drawing.Size(107, 21);
            this.pickedEvent.TabIndex = 7;
            this.pickedEvent.SelectedIndexChanged += new System.EventHandler(this.PickedEvent_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Location:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Start Time:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "End Time:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkDates
            // 
            this.chkDates.CheckOnClick = true;
            this.chkDates.FormattingEnabled = true;
            this.chkDates.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.chkDates.Location = new System.Drawing.Point(15, 279);
            this.chkDates.Name = "chkDates";
            this.chkDates.Size = new System.Drawing.Size(163, 109);
            this.chkDates.TabIndex = 12;
            this.chkDates.SelectedIndexChanged += new System.EventHandler(this.ChkDates_SelectedIndexChanged);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(71, 141);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(107, 20);
            this.txtNam.TabIndex = 14;
            this.txtNam.TextChanged += new System.EventHandler(this.TxtNam_TextChanged);
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(71, 167);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(107, 20);
            this.txtLoc.TabIndex = 15;
            this.txtLoc.TextChanged += new System.EventHandler(this.TxtLoc_TextChanged);
            // 
            // timStart
            // 
            this.timStart.CustomFormat = "h:mm tt";
            this.timStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timStart.Location = new System.Drawing.Point(86, 227);
            this.timStart.Name = "timStart";
            this.timStart.ShowUpDown = true;
            this.timStart.Size = new System.Drawing.Size(92, 20);
            this.timStart.TabIndex = 16;
            this.timStart.Value = new System.DateTime(2020, 2, 8, 0, 0, 0, 0);
            this.timStart.ValueChanged += new System.EventHandler(this.TimStart_ValueChanged);
            // 
            // timEnd
            // 
            this.timEnd.CustomFormat = "h:mm tt";
            this.timEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timEnd.Location = new System.Drawing.Point(86, 253);
            this.timEnd.Name = "timEnd";
            this.timEnd.ShowUpDown = true;
            this.timEnd.Size = new System.Drawing.Size(92, 20);
            this.timEnd.TabIndex = 17;
            this.timEnd.Value = new System.DateTime(2020, 2, 8, 0, 0, 0, 0);
            this.timEnd.ValueChanged += new System.EventHandler(this.TimEnd_ValueChanged);
            // 
            // btnDoIt
            // 
            this.btnDoIt.Location = new System.Drawing.Point(15, 414);
            this.btnDoIt.Name = "btnDoIt";
            this.btnDoIt.Size = new System.Drawing.Size(163, 23);
            this.btnDoIt.TabIndex = 18;
            this.btnDoIt.Text = "Add Semester";
            this.btnDoIt.UseVisualStyleBackColor = true;
            this.btnDoIt.Click += new System.EventHandler(this.btnDoIt_Click);
            // 
            // deChart
            // 
            this.deChart.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.deChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.deChart.Legends.Add(legend2);
            this.deChart.Location = new System.Drawing.Point(193, 12);
            this.deChart.Name = "deChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.deChart.Series.Add(series2);
            this.deChart.Size = new System.Drawing.Size(679, 416);
            this.deChart.TabIndex = 19;
            this.deChart.Text = "chart1";
            // 
            // colorPick
            // 
            this.colorPick.AutoCompleteCustomSource.AddRange(new string[] {
            "Red",
            "Green",
            "Blue"});
            this.colorPick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorPick.FormattingEnabled = true;
            this.colorPick.Location = new System.Drawing.Point(71, 193);
            this.colorPick.Name = "colorPick";
            this.colorPick.Size = new System.Drawing.Size(107, 21);
            this.colorPick.TabIndex = 21;
            this.colorPick.SelectedIndexChanged += new System.EventHandler(this.ColorPick_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Color:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 457);
            this.Controls.Add(this.colorPick);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deChart);
            this.Controls.Add(this.btnDoIt);
            this.Controls.Add(this.timEnd);
            this.Controls.Add(this.timStart);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.chkDates);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pickedEvent);
            this.Controls.Add(this.numEvent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datEnd);
            this.Controls.Add(this.datStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Google Calendar - HackBU 2020";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datStart;
        private System.Windows.Forms.DateTimePicker datEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numEvent;
        private System.Windows.Forms.ComboBox pickedEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox chkDates;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.DateTimePicker timStart;
        private System.Windows.Forms.DateTimePicker timEnd;
        private System.Windows.Forms.Button btnDoIt;
        private System.Windows.Forms.DataVisualization.Charting.Chart deChart;
        private System.Windows.Forms.ComboBox colorPick;
        private System.Windows.Forms.Label label9;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Assignment
{
    public partial class EditAlarm : Form
    {

        private static EditAlarm _EditAlarmInstance;
        public static EditAlarm EditAlarmInstance
        {
            get
            {
                if (_EditAlarmInstance == null)
                    _EditAlarmInstance = new EditAlarm();
                return _EditAlarmInstance;
            }
        }
        private static int btClicked = 0;
        public static int plLowerLimit = 90;
        public static int plUpperLimit = 120;
        public static int bpUpperLimit = 220;
        public static int bpLowerLimit = 200;
        public static int brUpperLimit = 90;
        public static int brLowerLimit = 95;
        public static int tUpperLimit = 120;
        public static int tLowerLimit = 90;
        private int lowerLimit;
        private int upperLimit;
        private static string text;

        public EditAlarm()
        {
            InitializeComponent();
            CurrentPulseRateBox.Text = plLowerLimit.ToString() + "      " + plUpperLimit.ToString();
            CurrentBloodPressureBox.Text = bpLowerLimit.ToString() + "      " + bpUpperLimit.ToString();
            CurrentBreathingRateBox.Text = brLowerLimit.ToString() + "      " + brUpperLimit.ToString();
            CurrentTemperatureBox.Text = tLowerLimit.ToString() + "      " + tUpperLimit.ToString();
            PulseRatePanel.Location = new Point(370, 135);
            BloodPressurePanle.Location = new Point(370, 135);
            BreathingRatePanel.Location = new Point(370, 135);
            TemperaturePanel.Location = new Point(370, 135);
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            PulseRatePanel.Visible = true;
            BloodPressurePanle.Visible = false;
            BreathingRatePanel.Visible = false;
            TemperaturePanel.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            PulseRatePanel.Visible = true;
            BloodPressurePanle.Visible = false;
            BreathingRatePanel.Visible = false;
            TemperaturePanel.Visible = false;
           
            LowerLimitBloodPressureBox.Clear();
            UpperLimitBloodPressureBox.Clear();
            LowerLimitBreathingRateBox.Clear();
            UpperLimitBreathingRateBox.Clear();
            LowerLimitTemperatureBox.Clear();
            UpperLimitTemperatureBox.Clear();
            //text = null;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            PulseRatePanel.Visible = false;
            BloodPressurePanle.Visible = true;
            BreathingRatePanel.Visible = false;
            TemperaturePanel.Visible = false;
            LowerLimitPulseRateBox.Clear();
            UpperLimitPulseRateBox.Clear();
            LowerLimitBreathingRateBox.Clear();
            UpperLimitBreathingRateBox.Clear();
            LowerLimitTemperatureBox.Clear();
            UpperLimitTemperatureBox.Clear();
            //text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            PulseRatePanel.Visible = false;
            BloodPressurePanle.Visible = false;
            BreathingRatePanel.Visible = true;
            TemperaturePanel.Visible = false;
            LowerLimitPulseRateBox.Clear();
            UpperLimitPulseRateBox.Clear();
            LowerLimitBloodPressureBox.Clear();
            UpperLimitBloodPressureBox.Clear();
            LowerLimitTemperatureBox.Clear();
            UpperLimitTemperatureBox.Clear();
            //text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
            PulseRatePanel.Visible = false;
            BloodPressurePanle.Visible = false;
            BreathingRatePanel.Visible = false;
            TemperaturePanel.Visible = true;
            LowerLimitPulseRateBox.Clear();
            UpperLimitPulseRateBox.Clear();
            LowerLimitBloodPressureBox.Clear();
            UpperLimitBloodPressureBox.Clear();
            LowerLimitBreathingRateBox.Clear();
            UpperLimitBreathingRateBox.Clear();
            //text = null;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            LowerLimitPulseRateBox.Clear();
            UpperLimitPulseRateBox.Clear();
            LowerLimitBloodPressureBox.Clear();
            UpperLimitBloodPressureBox.Clear();
            LowerLimitBreathingRateBox.Clear();
            UpperLimitBreathingRateBox.Clear();
            LowerLimitTemperatureBox.Clear();
            UpperLimitTemperatureBox.Clear();
            this.Hide();
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            PulseRatePanel.Visible = true;
            BloodPressurePanle.Visible = false;
            BreathingRatePanel.Visible = false;
            TemperaturePanel.Visible = false;
            PatientMenu.PatientMenuInstance.Show();

        }

        private void SavePulseRateLimitButton_Click(object sender, EventArgs e)
        {
            btClicked = 1;
            CurrentTextBoxUpdater();
            LowerLimitPulseRateBox.Clear();
            UpperLimitPulseRateBox.Clear();
            CurrentPulseRateBox.Text = text;
        }

        private void SaveBloodPressureLimitButton_Click(object sender, EventArgs e)
        {
            btClicked = 2;
            CurrentTextBoxUpdater();
            LowerLimitBloodPressureBox.Clear();
            UpperLimitBloodPressureBox.Clear();
        }

        private void SaveBreathingRateLimitButton_Click_1(object sender, EventArgs e)
        {
            btClicked = 3;
            CurrentTextBoxUpdater();
            LowerLimitBreathingRateBox.Clear();
            UpperLimitBreathingRateBox.Clear();
        }

        private void SaveTemperatureLimitButton_Click_1(object sender, EventArgs e)
        {
            btClicked = 4;
            CurrentTextBoxUpdater();
            LowerLimitTemperatureBox.Clear();
            UpperLimitTemperatureBox.Clear();
        }

        private void CurrentTextBoxUpdater()
        {
            
            switch (btClicked)
            {
                case 1:
                    TryToParse(LowerLimitPulseRateBox.Text, UpperLimitPulseRateBox.Text);
                    //CurrentPulseRateBox.Text = text;
                    break;
                case 2:
                    TryToParse(LowerLimitBloodPressureBox.Text, UpperLimitBloodPressureBox.Text);
                    CurrentBloodPressureBox.Text = text;
                    break;
                case 3:
                    TryToParse(LowerLimitBreathingRateBox.Text, UpperLimitBreathingRateBox.Text);
                    CurrentBreathingRateBox.Text = text; 
                    break;
                case 4:
                    TryToParse(LowerLimitTemperatureBox.Text, UpperLimitTemperatureBox.Text);
                    CurrentTemperatureBox.Text = text;
                    break;
            }
        }

        private void TryToParse(string a, string b)
        {
            
            bool result1 = Int32.TryParse(a, out lowerLimit);
            bool result2 = Int32.TryParse(b, out upperLimit);

            if (result1 == false || result2 == false)
            {
                MessageBox.Show("Please enter valid numbers", "invalid input", MessageBoxButtons.OK);
               // return null;

            } else if (lowerLimit >= upperLimit)
            {
                MessageBox.Show("Please Make sure lower limit is smaller than upper limit", "invalid input", MessageBoxButtons.OK);
                //return null;
            } else
            {
                text = lowerLimit.ToString() + "      " + upperLimit.ToString();
                SetLimitValues();
                //return text;
            }

        }

        private void SetLimitValues()
        {

                switch (btClicked)
                {
                    case 1:
                        Int32.TryParse(LowerLimitPulseRateBox.Text, out plLowerLimit);
                        Int32.TryParse(UpperLimitPulseRateBox.Text, out plUpperLimit);
                    break;
                    case 2:
                        Int32.TryParse(LowerLimitBloodPressureBox.Text, out bpLowerLimit);
                        Int32.TryParse(UpperLimitBloodPressureBox.Text, out bpUpperLimit);
                        break;
                    case 3:
                        Int32.TryParse(LowerLimitBreathingRateBox.Text, out brLowerLimit);
                        Int32.TryParse(UpperLimitBreathingRateBox.Text, out brLowerLimit);
                        break;
                    case 4:
                        Int32.TryParse(LowerLimitTemperatureBox.Text, out tLowerLimit);
                        Int32.TryParse(UpperLimitTemperatureBox.Text, out tUpperLimit);
                        break;

                }

            

        }

        public void SetDefaultAlarm(int i)
        {
            switch (i)
            {
                case 1:
                    DefaultAlarmUpdater(1);
                    break;
                case 2:
                    DefaultAlarmUpdater(2);
                    break;
                case 3:
                    DefaultAlarmUpdater(3);
                    break;
                case 4:
                    DefaultAlarmUpdater(4);
                    break;
                case 5:
                    DefaultAlarmUpdater(5);
                    break;
                case 6:
                    DefaultAlarmUpdater(6);
                    break;
                case 7:
                    DefaultAlarmUpdater(7);
                    break;
                case 8:
                    DefaultAlarmUpdater(8);
                    break;
            }
        }
        
        private void DefaultAlarmUpdater(int i)
        {
            DataTable dataTable = DataHandler.Instance.PatientUpdater(i);
            LowerLimitPulseRateBox.Text = dataTable.Rows[0][9].ToString();
            UpperLimitPulseRateBox.Text = dataTable.Rows[0][10].ToString();
            LowerLimitBloodPressureBox.Text = dataTable.Rows[0][11].ToString();
            UpperLimitBloodPressureBox.Text = dataTable.Rows[0][12].ToString();
            LowerLimitBreathingRateBox.Text = dataTable.Rows[0][13].ToString();
            UpperLimitBreathingRateBox.Text = dataTable.Rows[0][14].ToString();
            LowerLimitTemperatureBox.Text = dataTable.Rows[0][15].ToString();
            UpperLimitTemperatureBox.Text = dataTable.Rows[0][16].ToString();
        }

        //a method to regonizes our limit violation and raise a number to alert user;
    }
}

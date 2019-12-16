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
        //Implementing singleton pattern to only have one instance of the class
        private static EditAlarm _EditAlarmInstance;

        //checks if there already is an instance of the class if not it creates one and returns it
        public static EditAlarm EditAlarmInstance
        {
            get
            {
                if (_EditAlarmInstance == null)
                    _EditAlarmInstance = new EditAlarm();
                return _EditAlarmInstance;
            }
        }

        //Declaring variables to store data
        private static int btClicked = 0;
        public static int plLowerLimit;
        public static int plUpperLimit;
        public static int bpUpperLimit;
        public static int bpLowerLimit;
        public static int brUpperLimit;
        public static int brLowerLimit;
        public static int tUpperLimit;
        public static int tLowerLimit;
        private int lowerLimit;
        private int upperLimit;
        private static string text;

        public EditAlarm()
        {
            //Initialzing The controls, and setting different panels to be visible or invisible
            InitializeComponent();
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
            text = null;
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
            text = null;
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
            text = null;
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
            text = null;

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


        //The method will call a metheod and passes an integer to indicate which save button on which panel was clicked
        //Then it will clear the text boxes
        private void SavePulseRateLimitButton_Click(object sender, EventArgs e)
        {
            CurrentTextBoxUpdater(1);
            LowerLimitPulseRateBox.Clear();
            UpperLimitPulseRateBox.Clear();
        }

        private void SaveBloodPressureLimitButton_Click(object sender, EventArgs e)
        {
            CurrentTextBoxUpdater(2);
            LowerLimitBloodPressureBox.Clear();
            UpperLimitBloodPressureBox.Clear();
        }

        private void SaveBreathingRateLimitButton_Click_1(object sender, EventArgs e)
        {
            CurrentTextBoxUpdater(3);
            LowerLimitBreathingRateBox.Clear();
            UpperLimitBreathingRateBox.Clear();
        }

        private void SaveTemperatureLimitButton_Click_1(object sender, EventArgs e)
        {
            CurrentTextBoxUpdater(4);
            LowerLimitTemperatureBox.Clear();
            UpperLimitTemperatureBox.Clear();
        }


        //Gets called whenever a save button is clicked
        private void CurrentTextBoxUpdater(int i)
        {
            //Checks which button was clicked and based on that it will call another method and passes two string parameters 
            //If the value that was returned is equal to 1 calls a method to stores user input to the local varaible declared at the start and also it set the textbox to to text otherwise do nothing
            switch (i)
            {
                case 1:

                    if (TryToParse(LowerLimitPulseRateBox.Text, UpperLimitPulseRateBox.Text) == 1)
                    {
                        SetLimitValues(1);
                        CurrentPulseRateBox.Text = text;
                    }
                    break;
                case 2:
                    if (TryToParse(LowerLimitBloodPressureBox.Text, UpperLimitBloodPressureBox.Text) == 1)
                    {
                        SetLimitValues(2);
                        CurrentBloodPressureBox.Text = text;
                    }
                    break;
                case 3:
                    if (TryToParse(LowerLimitBreathingRateBox.Text, UpperLimitBreathingRateBox.Text) == 1)
                    {
                        SetLimitValues(3);
                        CurrentBreathingRateBox.Text = text;
                    }
                    break;
                case 4:
                    if (TryToParse(LowerLimitTemperatureBox.Text, UpperLimitTemperatureBox.Text) == 1)
                    {
                        SetLimitValues(4);
                        CurrentTemperatureBox.Text = text;
                    }
                    break;
            }
        }

        //The method will gets the passed parameters and sets them to lowerLimit, upperLimit
        //TryParse will return a boolean value if it is able to parse otherwise it will return false
        //If TryParse fails means user input is invalid, if it suceed but lower limit is bigger than upper limit if fails
        private int TryToParse(string a, string b)
        {
            
            bool result1 = Int32.TryParse(a, out lowerLimit);
            bool result2 = Int32.TryParse(b, out upperLimit);

            if (result1 == false || result2 == false)
            {
                MessageBox.Show("Please enter valid numbers", "invalid input", MessageBoxButtons.OK);
                return 0;

            } else if (lowerLimit >= upperLimit)
            {
                MessageBox.Show("Please Make sure lower limit is smaller than upper limit", "invalid input", MessageBoxButtons.OK);
                return 0;
            } else
            {
                text = lowerLimit.ToString() + "      " + upperLimit.ToString();
                
                return 1;
            }

        }

        //Method is called inside another method and it stores the user input to to the local variables
        private void SetLimitValues(int i)
        {

                switch (i)
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
                        Int32.TryParse(UpperLimitBreathingRateBox.Text, out brUpperLimit);
                        break;
                    case 4:
                        Int32.TryParse(LowerLimitTemperatureBox.Text, out tLowerLimit);
                        Int32.TryParse(UpperLimitTemperatureBox.Text, out tUpperLimit);
                        break;

                }

            

        }


        //This method is called from PatientSelection form
        //The method calls the PatientUpdater method in the DataHandler class and it gets the relevant rows to the patinet's lower limit and upper limit
        public void DefaultAlarmUpdater(int i)
        {
            DataTable dataTable = DataHandler.Instance.PatientUpdater(i);
            CurrentPulseRateBox.Text = dataTable.Rows[0][8].ToString() + "       " + dataTable.Rows[0][9].ToString();
            CurrentBloodPressureBox.Text = dataTable.Rows[0][10] + "       " + dataTable.Rows[0][11].ToString();
            CurrentBreathingRateBox.Text = dataTable.Rows[0][12] + "       " + dataTable.Rows[0][13].ToString();
            CurrentTemperatureBox.Text = dataTable.Rows[0][14] + "       " + dataTable.Rows[0][15].ToString();
            plLowerLimit = Convert.ToInt32(dataTable.Rows[0][8]);
            plUpperLimit = Convert.ToInt32(dataTable.Rows[0][9]);
            bpLowerLimit = Convert.ToInt32(dataTable.Rows[0][10]);
            bpUpperLimit = Convert.ToInt32(dataTable.Rows[0][11]);
            brLowerLimit = Convert.ToInt32(dataTable.Rows[0][12]);
            brUpperLimit = Convert.ToInt32(dataTable.Rows[0][13]);
            tLowerLimit = Convert.ToInt32(dataTable.Rows[0][14]);
            tUpperLimit = Convert.ToInt32(dataTable.Rows[0][15]);

        }

    }
}

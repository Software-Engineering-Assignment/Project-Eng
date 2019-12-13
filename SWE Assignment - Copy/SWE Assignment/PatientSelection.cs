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
    public partial class PatientSelection : Form
    {
        public static string labelText = "";

        private static PatientSelection _PatientSelectionInstance;

        public static PatientSelection PatientSelectionInstance { 
            get{
                if (_PatientSelectionInstance == null)
                    _PatientSelectionInstance = new PatientSelection();
                return _PatientSelectionInstance;
            }
        }

        public PatientSelection()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelText = "BedSide 1";
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            PatientMenu.PatientMenuInstance.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelText = "BedSide 2";
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            //call patient menu populator 
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelText = "BedSide 3";
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelText = "BedSide 4";
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelText = "BedSide 5";
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelText = "BedSide 6";
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelText = "BedSide 7";
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelText = "BedSide 8";
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            PatientMenu.PatientMenuInstance.Show();
        }
    }
}

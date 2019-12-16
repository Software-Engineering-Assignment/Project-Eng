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
        //Implementing singleton pattern to only have one instance of the class
        private static PatientSelection _PatientSelectionInstance;

        //checks if there already is an instance of the class if not it creates one and returns it
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

            //Sets alarm values to zero so that each monitoring session will be distinct
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;

            //Gets the default value of lower limits and upper limits base on patient selected from database
            EditAlarm.EditAlarmInstance.DefaultAlarmUpdater(1);

            //Gets the patinet information from the database and updates the UI
            PatientMenu.PatientMenuInstance.ControlUpdater(1);

            //Gets the patients instance and will show it
            PatientMenu.PatientMenuInstance.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            EditAlarm.EditAlarmInstance.DefaultAlarmUpdater(2);
            PatientMenu.PatientMenuInstance.ControlUpdater(2);
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            EditAlarm.EditAlarmInstance.DefaultAlarmUpdater(3);
            PatientMenu.PatientMenuInstance.ControlUpdater(3);
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            EditAlarm.EditAlarmInstance.DefaultAlarmUpdater(4);
            PatientMenu.PatientMenuInstance.ControlUpdater(4);
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            EditAlarm.EditAlarmInstance.DefaultAlarmUpdater(5);
            PatientMenu.PatientMenuInstance.ControlUpdater(5);
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            EditAlarm.EditAlarmInstance.DefaultAlarmUpdater(6);
            PatientMenu.PatientMenuInstance.ControlUpdater(6);
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            EditAlarm.EditAlarmInstance.DefaultAlarmUpdater(7);
            PatientMenu.PatientMenuInstance.ControlUpdater(7);
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            EditAlarm.EditAlarmInstance.DefaultAlarmUpdater(8);
            PatientMenu.PatientMenuInstance.ControlUpdater(8);
            PatientMenu.PatientMenuInstance.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Log out button, will get the instance of the login and show it the user.
            this.Hide();
            Login.Instance.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

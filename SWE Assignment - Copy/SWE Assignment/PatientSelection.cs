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
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            //EditAlarm.EditAlarmInstance.SetDefaultAlarm(1);
            PatientMenu.PatientMenuInstance.PatientMenueUpdater(1);
            PatientMenu.PatientMenuInstance.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            //EditAlarm.EditAlarmInstance.SetDefaultAlarm(2);
            PatientMenu.PatientMenuInstance.PatientMenueUpdater(2);
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            //EditAlarm.EditAlarmInstance.SetDefaultAlarm(3);
            PatientMenu.PatientMenuInstance.PatientMenueUpdater(3);
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            //EditAlarm.EditAlarmInstance.SetDefaultAlarm(4);
            PatientMenu.PatientMenuInstance.PatientMenueUpdater(4);
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            //EditAlarm.EditAlarmInstance.SetDefaultAlarm(5);
            PatientMenu.PatientMenuInstance.PatientMenueUpdater(5);
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            //EditAlarm.EditAlarmInstance.SetDefaultAlarm(6);
            PatientMenu.PatientMenuInstance.PatientMenueUpdater(6);
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            //EditAlarm.EditAlarmInstance.SetDefaultAlarm(7);
            PatientMenu.PatientMenuInstance.PatientMenueUpdater(7);
            PatientMenu.PatientMenuInstance.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm.bloodPressureAlarmRaised = 0;
            Alarm.breathingRateAlarmRaised = 0;
            Alarm.pulseRateAlarmRaised = 0;
            Alarm.temperatureAlarmRaised = 0;
            //EditAlarm.EditAlarmInstance.SetDefaultAlarm(8);
            PatientMenu.PatientMenuInstance.PatientMenueUpdater(8);
            PatientMenu.PatientMenuInstance.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Instance.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

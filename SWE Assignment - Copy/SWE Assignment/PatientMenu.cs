using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SWE_Assignment
{
    public partial class PatientMenu : Form
    {
        Patient newPatient = new Patient();

        public static string getPatientName;
        public static string getPatientLastName;
        public static string getPatientGender;
        public static DateTime getPetientBD;
        public static string getPatientHeight;
        public static string getPatientWeight;
        public static string update;

        public static bool pulseRateOn = false;
        private bool bloodPressureOn = false;
        private bool breathingRateOn = false;
        private bool temperatureOn = false;


        public PatientMenu()
        {
            InitializeComponent();
            newPatient.PatientDetailPopulator();

            PatientFirstNameBox.Text = getPatientName;
            PatientLastNameBox.Text = getPatientLastName;
            PatientGenderBox.Text = getPatientGender;
            PatientDateofBirthBox.Text = getPetientBD.ToString();
            PatientHeightBox.Text = getPatientHeight;
            PatientWeightBox.Text = getPatientWeight;

            

            label1.Text = PatientSelection.labelText;
            panel14.Location = new Point(0, 0);
            panel9.Location = new Point(0, 0);
            panel8.Location = new Point(0, 0);
            PulseRatePicturebox.Image = Properties.Resources.connection_status_off;
            BloodPressurePictureBox.Image = Properties.Resources.connection_status_off;
            BreathingRatePictureBox.Image = Properties.Resources.connection_status_off;
            TemperaturePictureBox.Image = Properties.Resources.connection_status_off;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel7.BringToFront();
            panel8.Visible = false;
            panel9.Visible = false;
            panel14.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;
            panel7.BringToFront();
            panel8.Visible = false;
            panel9.Visible = false;
            panel14.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;
            panel8.Visible = true;
            panel8.BringToFront();
            panel9.Visible = false;
            panel14.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel9.BringToFront();
            panel14.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel14.Visible = true;
            panel14.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;
            this.Hide();
            PatientSelection f2 = new PatientSelection();
            f2.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //once clikced check to see if any module is on? if it is prompt user with a message to turn them off first.
            //write a method for this purpose 
            if (CheckModules() == 1)
            {
                this.Hide();
                EditAlarm f6 = new EditAlarm();
                f6.Show();
            } else
            {
                MessageBox.Show("Dear User, Please Make sure all modules are turned off before setting new alarm limits");
                CheckModules();
            }
            
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            PulseRatePicturebox.Image = Properties.Resources.connection_status_on;
            pulseRateOn = true;

            
        }

        private void PulseRateOffButton_Click(object sender, EventArgs e)
        {
            PulseRatePicturebox.Image = Properties.Resources.connection_status_off;
            pulseRateOn = false;
            PulseRateMonitortingBox.Text = null;
        }

        private void BloodPressureOnButton_Click(object sender, EventArgs e)
        {
            BloodPressurePictureBox.Image = Properties.Resources.connection_status_on;
            bloodPressureOn = true;
        }

        private void BloodPressureOffButton_Click(object sender, EventArgs e)
        {
            BloodPressurePictureBox.Image = Properties.Resources.connection_status_off;
            bloodPressureOn = false;
        }

        private void BreathingRateOnButton_Click(object sender, EventArgs e)
        {
            BreathingRatePictureBox.Image = Properties.Resources.connection_status_on;
            breathingRateOn = true;
        }

        private void BreathingRateOffButton_Click(object sender, EventArgs e)
        {
            BreathingRatePictureBox.Image = Properties.Resources.connection_status_off;
            breathingRateOn = false;
        }

        private void TemperatureOnButton_Click(object sender, EventArgs e)
        {
            TemperaturePictureBox.Image = Properties.Resources.connection_status_on;
            temperatureOn = true;
        }

        private void TemperatureOffButton_Click(object sender, EventArgs e)
        {
            TemperaturePictureBox.Image = Properties.Resources.connection_status_off;
            temperatureOn = false;
        }

        private void PatientMenu_Load(object sender, EventArgs e)
        {
            
        }


        private int CheckModules()
        {
            int proceed;
            do
            {
                if (pulseRateOn || bloodPressureOn || breathingRateOn || temperatureOn == true)
                {
                    
                    return proceed = 0;
                }

            } while (pulseRateOn && bloodPressureOn && breathingRateOn && temperatureOn == false);

            return proceed = 1;   
            
        }

        private void ReadFromCsvButton_Click(object sender, EventArgs e)
        {
            RichBoxPopulator();   
        }

        private string RichBoxPopulator()
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string readfile = File.ReadAllText(filename); 
                return richTextBox1.Text = readfile;
            }
            else
                return null;
        }

        
        private void PatientDateofBirthBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

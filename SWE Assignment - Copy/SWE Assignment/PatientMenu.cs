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

    //Once Random number gens work define some logic to change the text box color if our random number is close to upper or lower limit
    public partial class PatientMenu : Form
    {

        private static PatientMenu _PatientMenuInstance;
        public static PatientMenu PatientMenuInstance
        {
            get
            {
                if (_PatientMenuInstance == null)
                    _PatientMenuInstance = new PatientMenu();
                return _PatientMenuInstance;
            }
        }

        Patient newPatient = Patient.Instance;
        Alarm newAlarm = new Alarm();
        public static string getPatientName; 
        public static string getPatientLastName;
        public static string getPatientGender;
        public static DateTime getPetientBD;
        public static string getPatientHeight;
        public static string getPatientWeight;
        public static string update;

        
        public static bool pulseRateOn = false;
        public static bool bloodPressureOn = false;
        public static bool breathingRateOn = false;
        public static bool temperatureOn = false;
        

        public PatientMenu()
        {
            InitializeComponent();
            //newPatient.PropertyChanged += _PulseRate_PropertyChanged;
            newPatient.PropertyChanged += _TextBox_PropertyChanged;
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
            textBox15.Text = "Pulse rate module is off";
            BloodPressurePictureBox.Image = Properties.Resources.connection_status_off;
            textBox16.Text = "Blood pressure module is off";
            BreathingRatePictureBox.Image = Properties.Resources.connection_status_off;
            textBox17.Text = "Braething rate module is off";
            TemperaturePictureBox.Image = Properties.Resources.connection_status_off;
            textBox18.Text = "Temperature module is off";
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
            panel15.Visible = false;
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
            panel15.Visible = false;

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
            panel15.Visible = false;
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
            panel15.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (CheckModules() == 1)
            {
                this.Hide();
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
                panel15.Visible = true;
                PatientSelection.PatientSelectionInstance.Show();
            }
            else
            {
                MessageBox.Show("Dear User, Please Make sure all modules are turned off");
            }
            
           
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            PulseRatePicturebox.Image = Properties.Resources.connection_status_on;
            textBox15.Text = "Pulse rate module is on";
            pulseRateOn = true;
            newPatient.PL(true);
        }

        private void PulseRateOffButton_Click(object sender, EventArgs e)
        {
            PulseRatePicturebox.Image = Properties.Resources.connection_status_off;
            textBox15.Text = "Pulse rate module is off";
            pulseRateOn = false;
            newPatient.PL(false);
            PulseRateMonitortingBox.Text = null;
        }

        private void BloodPressureOnButton_Click(object sender, EventArgs e)
        {
            BloodPressurePictureBox.Image = Properties.Resources.connection_status_on;
            textBox16.Text = "Blood pressure module is on";
            bloodPressureOn = true;
            newPatient.BP(true);

            
        }

        private void BloodPressureOffButton_Click(object sender, EventArgs e)
        {
            BloodPressurePictureBox.Image = Properties.Resources.connection_status_off;
            textBox16.Text = "Blood pressure module is off";
            bloodPressureOn = false;
            newPatient.BP(false);
            BloodPressureMonitortingBox.Text = null;
        }

        private void BreathingRateOnButton_Click(object sender, EventArgs e)
        {
            BreathingRatePictureBox.Image = Properties.Resources.connection_status_on;
            textBox17.Text = "Braething rate module is on";
            breathingRateOn = true;
            newPatient.BR(true);
            
        }

        private void BreathingRateOffButton_Click(object sender, EventArgs e)
        {
            BreathingRatePictureBox.Image = Properties.Resources.connection_status_off;
            textBox17.Text = "Braething rate module is off";
            breathingRateOn = false;
            newPatient.BR(false);
            BreathingRateMonitortingBox.Text = null;
        }

        private void TemperatureOnButton_Click(object sender, EventArgs e)
        {
            TemperaturePictureBox.Image = Properties.Resources.connection_status_on;
            textBox18.Text = "Temperature module is on";
            temperatureOn = true;
            newPatient.T(true);
            
        }

        private void TemperatureOffButton_Click(object sender, EventArgs e)
        {
            TemperaturePictureBox.Image = Properties.Resources.connection_status_off;
            textBox18.Text = "Temperature module is off";
            temperatureOn = false;
            newPatient.T(false);
            TemperatureMonitortingBox.Text = null;
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


        //dont let the dialog accept every type
        private string RichBoxPopulator()
        {
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (CheckModules() == 1)
            {
                this.Hide();
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
                panel15.Visible = true;
                EditAlarm.EditAlarmInstance.Show();
            }
            else
            {
                MessageBox.Show("Dear User, Please Make sure all modules are turned off before setting new alarm limits");
            }
        }


        //https://stackoverflow.com/questions/12837305/cross-thread-operation-not-valid-how-to-access-winform-elements-from-another-mo/12837412

        void _TextBox_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "PulseRate":
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        PulseRateMonitortingBox.Text = newPatient.PulseRate.ToString();
                        newAlarm.PulseRateAlarm(newPatient.PulseRate);
                    }));

                    break;
                case "BreathingRate":
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        BreathingRateMonitortingBox.Text = newPatient.BreathingRate.ToString();
                        newAlarm.BreathingRateAlarm(newPatient.BreathingRate);
                    }));
                    
                    break;
                case "Temperature":
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        TemperatureMonitortingBox.Text = newPatient.Temperature.ToString();
                        newAlarm.TemperatureAlarm(newPatient.Temperature);
                    }));
                    break;

                case "BloodPressure":
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        BloodPressureMonitortingBox.Text = newPatient.BloodPressure.ToString();
                        newAlarm.BloodPressureAlarm(newPatient.BloodPressure);
                    }));
                    break;
            }
        }
    }
}

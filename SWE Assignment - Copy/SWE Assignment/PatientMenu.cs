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
using System.Data.SqlClient;


namespace SWE_Assignment
{

    public partial class PatientMenu : Form
    {
        //Implementing singleton pattern to only have one instance of the class
        private static PatientMenu _PatientMenuInstance;

        //checks if there already is an instance of the class if not it creates one and returns it
        public static PatientMenu PatientMenuInstance
        {
            get
            {
                if (_PatientMenuInstance == null)
                    _PatientMenuInstance = new PatientMenu();
                return _PatientMenuInstance;
            }
        }

        //sets the instance of the Patient to the newPatient
        //Create a new instance of alarm
        Patient newPatient = Patient.Instance;
        Alarm newAlarm = new Alarm();

        //declaring boolean variables
        public static bool pulseRateOn = false;
        public static bool bloodPressureOn = false;
        public static bool breathingRateOn = false;
        public static bool temperatureOn = false;
        

        public PatientMenu()
        {
            InitializeComponent();
            //Subscribing to the PropertyChanged event inside the Patient class
            //It will notify the _TextBox_PropertyChanged everytime the event in being triggered 
            newPatient.PropertyChanged += _TextBox_PropertyChanged;

            //Setting default values 
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

        
        //Setting different panels to visible or invisible based on user button click 
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

            //Calls a method to make sure all modules are off before letting the user to proceed
            if (CheckModules() == 1)
            {
                //If true hide the form and get the PatientSelection instance and show
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
                richTextBox1.Clear();
                PatientSelection.PatientSelectionInstance.Show();
            }
            else
            {
                //If false prompt the user with an error message
                MessageBox.Show("Dear User, Please Make sure all modules are turned off");
            }
            
           
        }
        
        //If the user clicks on "ON" button for pulse rate module
        private void button6_Click(object sender, EventArgs e)
        {
            //Change the image of the picturebox and change the text of the textbox
            //Set the pulseRateOn to true so that CheckModules() work as intended
            //Call the method inside the Patient class and pass True so that it starts generating random numbers
            PulseRatePicturebox.Image = Properties.Resources.connection_status_on;
            textBox15.Text = "Pulse rate module is on";
            pulseRateOn = true;
            newPatient.PL(true);
        }

        //If the user clicks on "OFF" button for pulse rate module
        private void PulseRateOffButton_Click(object sender, EventArgs e)
        {
            //Change the image of the picturebox and change the text of the textbox
            //Set the pulseRateOn to true so that CheckModules() work as intended
            //Call the method inside the Patient class and pass False so that it stops generating random numbers
            //Clear the textbox
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



        //A method to check if there is any module "ON"  
        private int CheckModules()
        {
            do
            {
                if (pulseRateOn || bloodPressureOn || breathingRateOn || temperatureOn == true)
                {
                    
                    return 0;
                }

            } while (pulseRateOn && bloodPressureOn && breathingRateOn && temperatureOn == false);

            return 1;   
            
        }


        //If the user click on the read from CSV file button
        private void ReadFromCsvButton_Click(object sender, EventArgs e)
        {
            //call the method
            RichBoxPopulator();   
        }


        
        private string RichBoxPopulator()
        {
            //Makes sure the user is only able to select a CSV file 
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            DialogResult result = openFileDialog1.ShowDialog();
            
            //It will checks the results and will fill the text box with text from CSV file
            //If user close the FileDialog it will return null to stop program from throwing exception
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


            //This methods listens to the events that being triggered by the changes in the properties inside the patient class
        void _TextBox_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //Switch statement to figure out which properies caused the event to be triggered
            switch (e.PropertyName)
            {
                //If the event is being triggered by PulseRate property value change get the new value and set it to the textbox
                //Call the PulseRateAlarm method in the alarm calss and pass the new value to being checked
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

        //This method is used to be called from the Patient Selection form, and it will updates the UI controls based on the selected patient
        //The method calls a mthod inside the DataHandler class that itself returns a DataTable 
        public void ControlUpdater(int i)
        {
            DataTable dataTable = DataHandler.Instance.PatientUpdater(i);
            PatientFirstNameBox.Text = dataTable.Rows[0][0].ToString();
            label1.Text = "BedSide " + dataTable.Rows[0][1].ToString();
            PatientLastNameBox.Text = dataTable.Rows[0][2].ToString();
            PatientDateofBirthBox.Text = dataTable.Rows[0][3].ToString();
            PatientGenderBox.Text = dataTable.Rows[0][4].ToString();
            PatientNHSNumber.Text = dataTable.Rows[0][5].ToString();
            PatientHeightBox.Text = dataTable.Rows[0][6].ToString();
            PatientWeightBox.Text = dataTable.Rows[0][7].ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Timers;

namespace SWE_Assignment
{


    class Patient : INotifyPropertyChanged
    {

        Random rnd = new Random();


        private int _pulseRate;
        public int PulseRate
        {
            get { return _pulseRate; }
            set
            {
               
                  _instance._pulseRate = value;
                OnPropertyChanged("PulseRate");
            }
        }

        private int _breathingRate;
        public int BreathingRate
        {
            get { return _breathingRate; }
            set
            {
                _breathingRate = value;
                OnPropertyChanged("BreathingRate");
            }
        }

        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                OnPropertyChanged("Temperature");
            }
        }

        private int _bloodPressure;

        public int BloodPressure
        {
            get { return _bloodPressure; }
            set
            {
                _bloodPressure = value;
                OnPropertyChanged("BloodPressure");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string properyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properyName));
        }

        private static Patient _instance = null;
        private static readonly object _padlock = new object();

        Timer pulseRateTimer;
        Timer breatingRateTimer;
        Timer temperatureTimer;
        Timer bloodPressureTimer;
        //Random rnd;

        public static Patient Instance
        {
            get
            {
                lock (_padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Patient();
                    }
                    return _instance;
                }
            }
        }

        private Patient()
        {
            //Random rnd = new Random();
            pulseRateTimer = new Timer();
            pulseRateTimer.AutoReset = true;
            pulseRateTimer.Interval = 1000;
            pulseRateTimer.Elapsed += PulseRateGenerator;

            breatingRateTimer = new Timer();
            breatingRateTimer.AutoReset = true;
            breatingRateTimer.Interval = 2000;
            breatingRateTimer.Elapsed += BreatingRateGenerator;

            temperatureTimer = new Timer();
            temperatureTimer.AutoReset = true;
            temperatureTimer.Interval = 1000;
            temperatureTimer.Elapsed += TemperatureGenerator;

            bloodPressureTimer = new Timer();
            bloodPressureTimer.AutoReset = true;
            bloodPressureTimer.Interval = 1000;
            bloodPressureTimer.Elapsed += BloodPressureGenerator;

        }

        public void PL(bool srt)
        {
            pulseRateTimer.Enabled = srt;
        }

        private void PulseRateGenerator(object sender, ElapsedEventArgs e)
        {

            PulseRate = rnd.Next(EditAlarm.plLowerLimit -10, EditAlarm.plUpperLimit +10);
            Console.WriteLine(PulseRate);
        }

        public void BR(bool srt)
        {
            breatingRateTimer.Enabled = srt;
        }

        private void BreatingRateGenerator(object sender, ElapsedEventArgs e)
        {

            BreathingRate = rnd.Next(EditAlarm.brLowerLimit - 10, EditAlarm.brUpperLimit + 10);
            Console.WriteLine(BreathingRate);
        }

        public void T(bool srt)
        {
            temperatureTimer.Enabled = srt;
        }

        private void TemperatureGenerator(object sender, ElapsedEventArgs e)
        {

            Temperature = rnd.Next(EditAlarm.tLowerLimit - 5, EditAlarm.tUpperLimit +5);
            Console.WriteLine(Temperature);
        }


        public void BP(bool srt)
        {
            bloodPressureTimer.Enabled = srt;
        }

        private void BloodPressureGenerator(object sender, ElapsedEventArgs e)
        {

            BloodPressure = rnd.Next(EditAlarm.bpLowerLimit -10, EditAlarm.bpUpperLimit+10); 
            Console.WriteLine(BloodPressure);
        }




        private static string patientName;
        private static string patientLastname;
        private static string patientGender;
        private static DateTime patientBirdthday;
        private static int patientHeight = 185;
        private static int patientWeight = 65;


        public void PatientDetailPopulator()
        {
            //Codes to get stuff from database?
            patientName = "Shayan";
            PatientMenu.getPatientName = patientName;

            //code to get lastname
            patientLastname = "MHD";
            PatientMenu.getPatientLastName = patientLastname;

            patientGender = "Male";
            PatientMenu.getPatientGender = patientGender;

            patientBirdthday = new DateTime(1997, 2, 15);
            PatientMenu.getPetientBD = patientBirdthday;

            //better conversion or string builder 
            patientHeight = 185;
            PatientMenu.getPatientHeight = patientHeight + " Cm";

            patientWeight = 89;
            PatientMenu.getPatientWeight = patientWeight + " Kg";
           
        }


       
    }

    
    
}

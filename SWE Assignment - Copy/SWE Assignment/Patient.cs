using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Timers;

namespace SWE_Assignment
{

    //implementing INotifyPropertyChanged to allow us to tell the other classes about the changes that we want
    class Patient : INotifyPropertyChanged
    {
        //Creating new instane of the random class
        Random rnd = new Random();

        //Declaring properties
        private int _pulseRate;

        //If the value changes it will trigger the event
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


        //Creating an event
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string properyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properyName));
        }

        private static Patient _instance = null;
        private static readonly object _padlock = new object();

        //Declaring data fields
        Timer pulseRateTimer;
        Timer breatingRateTimer;
        Timer temperatureTimer;
        Timer bloodPressureTimer;


        public static Patient Instance
        {
            get
            {
                
                    if (_instance == null)
                    {
                        _instance = new Patient();
                    }
                    return _instance;
                
            }
        }

        private Patient()
        {
            //adding each method to their timer
            //setting autoreset and interval
            //getting Timer.Enabled from PatientMenu
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

        //Starts the timer or Stops the timer
        public void PL(bool srt)
        {
            pulseRateTimer.Enabled = srt;
        }

        //Once timer started the method is run in 1 second intervals
        //By (EditAlarm.plLowerLimit -5, EditAlarm.plUpperLimit +5) making sure limits are violated so that the alarm works properly 
        private void PulseRateGenerator(object sender, ElapsedEventArgs e)
        {

            PulseRate = rnd.Next(EditAlarm.plLowerLimit -5, EditAlarm.plUpperLimit +5);
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




       
    }

    
    
}

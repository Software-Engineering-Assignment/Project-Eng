using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SWE_Assignment
{


    class Patient
    {
        public string pulseRate;
        public string breathingRate;
        public string temperature;
        private static string patientName;
        private static string patientLastname;
        private static string patientGender;
        private static DateTime patientBirdthday;
        private static int patientHeight = 185;
        private static int patientWeight = 65;

        //public TextBox TextBoxToUpdate { get; set; }
       // Action<string> updateTextBoxDelegate;

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

        //raise and event once the value changes to textbox gets updated
        public string PulseRate()
        {
            int i;
            Random rnd = new Random();
            bool start = PatientMenu.pulseRateOn;
            while (start == true)
            {
                 i = rnd.Next(EditAlarm.plLowerLimit - 10, EditAlarm.plUpperLimit + 10);
                 pulseRate = i.ToString();
                 Thread.Sleep(1000);
                 return pulseRate;
            }
            return null;


        }
        
        public string BreathingRate()
        {
            int i;
            Random rnd = new Random();
            bool start = PatientMenu.breathingRateOn;
            while (start == true)
            {
                i = rnd.Next(EditAlarm.brLowerLimit - 10, EditAlarm.brUpperLimit + 10);
                breathingRate = i.ToString();
                Thread.Sleep(10000);
                return breathingRate;
            }

            return null;
    
        }

        public string Temperature()
        {
            int i;
            Random rnd = new Random();
            bool start = PatientMenu.temperatureOn;
            while (start == true)
            {
                i = rnd.Next(EditAlarm.tLowerLimit - 10, EditAlarm.tUpperLimit + 10);
                temperature = i.ToString();
                Thread.Sleep(10000);
                return temperature;
            }

            return null;

        }
    }

    
    
}

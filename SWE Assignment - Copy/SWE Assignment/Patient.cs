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
        public static int pulseRate;

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

        public int PulseRate()
        {
           // int ourRnd;
            Random rnd = new Random();
            //System.Timers.Timer t = new System.Timers.Timer(1000);
            bool start = PatientMenu.pulseRateOn;
            while (start == true)
            {
                 pulseRate = rnd.Next(EditAlarm.plLowerLimit - 10, EditAlarm.plUpperLimit + 10);
                 Thread.Sleep(2000);
                return pulseRate; 
            }

            return 0;

        }
    }

    
    
}

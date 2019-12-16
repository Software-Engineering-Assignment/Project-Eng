using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SWE_Assignment
{
    class Alarm
    {
        //Declaring variables to keep track of how many times a module has violated the limits 
        public static int pulseRateAlarmRaised = 0;
        public static int bloodPressureAlarmRaised = 0;
        public static int breathingRateAlarmRaised = 0;
        public static int temperatureAlarmRaised = 0;

        //The method is called from PatientMenu whenever a new number is being generated and the number is passed to this method
        //Method will check if the new number is equal to 0 so it will call a method inside AlarmPopup to show emergency alarm
        //If the new number is smaller than lower limit or bigger than upper limit it will call the method inside AlarmPopup to show medium priority alarm
        public void PulseRateAlarm(int i)
        {
            if (i == 0)
            {
                pulseRateAlarmRaised++;
                AlarmPopup.AlarmInstance.RaiseAlarm(1);
            }
            else if (i < EditAlarm.plLowerLimit || i > EditAlarm.plUpperLimit)
            {
                pulseRateAlarmRaised++;
                AlarmPopup.AlarmInstance.RaiseAlarm(2);
                Console.WriteLine("Pulse rate alarm Has been Raised {0} times", pulseRateAlarmRaised);
            }
        }

        public void BloodPressureAlarm(int i)
        {
            if (i == 0)
            {
                bloodPressureAlarmRaised++;
                AlarmPopup.AlarmInstance.RaiseAlarm(1);
            }
            else if (i < EditAlarm.bpLowerLimit || i > EditAlarm.bpUpperLimit)
            {
                bloodPressureAlarmRaised++;
                AlarmPopup.AlarmInstance.RaiseAlarm(2);
                Console.WriteLine("Blood ressure alarm Has been Raised {0} times", bloodPressureAlarmRaised);
            }
        }

        public void BreathingRateAlarm(int i)
        {
            if (i == 0)
            {
                breathingRateAlarmRaised++;
                AlarmPopup.AlarmInstance.RaiseAlarm(1);
            }
            else if (i < EditAlarm.brLowerLimit || i > EditAlarm.brUpperLimit)
            {
                breathingRateAlarmRaised++;
                AlarmPopup.AlarmInstance.RaiseAlarm(2);
                Console.WriteLine("Breathing rate alarm Has been Raised {0} times", breathingRateAlarmRaised);

            }
        }

        public void TemperatureAlarm(int i)
        {

            if (i == 0 )
            {
                temperatureAlarmRaised++;
                AlarmPopup.AlarmInstance.RaiseAlarm(1);
            }
            else if (i < EditAlarm.tLowerLimit || i > EditAlarm.tUpperLimit)
            {
                temperatureAlarmRaised++;
                AlarmPopup.AlarmInstance.RaiseAlarm(2);
                Console.WriteLine("Temperature alarm Has been Raised {0} times", temperatureAlarmRaised);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SWE_Assignment
{
    class Alarm
    {
        public static int pulseRateAlarmRaised = 0;
        public static int bloodPressureAlarmRaised = 0;
        public static int breathingRateAlarmRaised = 0;
        public static int temperatureAlarmRaised = 0;
        public void PulseRateAlarm(int i)
        {
            if (i < EditAlarm.plLowerLimit || i > EditAlarm.plUpperLimit)
            {
                pulseRateAlarmRaised++;
                AlarmPopup.AlarmInstance.Show();
                Console.WriteLine("Pulse rate alarm Has been Raised {0} times", pulseRateAlarmRaised);
            }
        }

        public void BloodPressureAlarm(int i)
        {
            if (i < EditAlarm.bpLowerLimit || i > EditAlarm.bpUpperLimit)
            {
                bloodPressureAlarmRaised++;
                AlarmPopup.AlarmInstance.Show();
                Console.WriteLine("Blood ressure alarm Has been Raised {0} times", bloodPressureAlarmRaised);
            }
        }

        public void BreathingRateAlarm(int i)
        {
            
            if (i < EditAlarm.brLowerLimit || i > EditAlarm.brUpperLimit)
            {
                breathingRateAlarmRaised++;
                AlarmPopup.AlarmInstance.Show();
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

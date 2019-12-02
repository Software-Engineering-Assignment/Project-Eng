using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Assignment
{
    class Bed
    {
        private string patientName;
        private int age;
        private int userID;
        private bool management;
        private bool medicalStaff;
        private bool consultant;
        private string phoneNumber;
        private string email;

        private float bloodPressureDiastollic;
        private float bloodPressureSystolic;
        private float temp;
        private float heartRate;
        private float breathingRate;

        private float hRateUpperLimit;
        private float hRateLowerLimit;
        private float bRateUpperLimit;
        private float bRateLowerLimit;
        private float tempUpperLimit;
        private float tempLowerLimit;
        private float bPressureUpperLimit;
        private float bPressureLowerLimit;

        public string PatientName
        {
            get
            {
                return patientName;
            }
            set
            {
                patientName = value;
            }
        }

        public float BloodPressureDiastollic
        {
            get
            {
                return bloodPressureDiastollic;
            }
            set
            {
                bloodPressureDiastollic = value;
            }
        }

    }
}

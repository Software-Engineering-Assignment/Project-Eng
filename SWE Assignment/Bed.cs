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
        private string lastname;
        private int age;
        private int userID;        
        private string phoneNumber;
        private string email;
        private string nhsNumber;
        private int bedsideNo;
        private string gender;

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

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
               lastname = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public int BedsideNo
        {
            get
            {
                return bedsideNo;
            }
            set
            {
                bedsideNo = value;
            }
        }

        public string NhsNumber
        {
            get
            {
                return nhsNumber;
            }
            set
            {
                nhsNumber = value;
            }
        }


        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public int UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public float BreathingRate
        {
            get
            {
                return breathingRate;
            }
            set
            {
                breathingRate = value;
            }
        }

     
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

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

        public float BloodPressureSystolic
        {
            get
            {
                return bloodPressureSystolic;
            }
            set
            {
                bloodPressureSystolic = value;
            }
        }

        public float Temp
        {
            get
            {
                return temp;
            }
            set
            {
                temp = value;
            }
        }

        public float HeartRate
        {
            get
            {
                return heartRate;
            }
            set
            {
                heartRate = value;
            }
        }

        public Bed(int patientNumber)
        {
            
        }



    }
}

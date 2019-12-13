using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Assignment
{
    class HospitalRoom
    {
        //create instances of the patient class here and set attributes using the database
        Bed patient1 = new Bed(1);
        Bed patient2 = new Bed(2);
        Bed patient3 = new Bed(3);
        Bed patient4 = new Bed(4);
        Bed patient5 = new Bed(5);
        Bed patient6 = new Bed(6);
        Bed patient7 = new Bed(7);
        Bed patient8 = new Bed(8);

        public static int StaffID;
        

        public HospitalRoom()
        {
            DataHandler.Instance.GetPatientInfo(ref patient1, 1);
            DataHandler.Instance.GetPatientInfo(ref patient2, 2);
            DataHandler.Instance.GetPatientInfo(ref patient3, 3);
            DataHandler.Instance.GetPatientInfo(ref patient4, 4);
            DataHandler.Instance.GetPatientInfo(ref patient5, 5);
            DataHandler.Instance.GetPatientInfo(ref patient6, 6);
            DataHandler.Instance.GetPatientInfo(ref patient7, 7);
            DataHandler.Instance.GetPatientInfo(ref patient8, 8);

        }
    }
}

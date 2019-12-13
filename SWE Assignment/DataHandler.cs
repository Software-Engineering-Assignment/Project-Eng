using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SWE_Assignment
{
    class DataHandler
    {
        
        private static DataHandler _instance;

        
        private static string dBConnString;
   
        private SqlConnection sqlconnector;

        private SqlDataAdapter adapter;

        
        public static DataHandler Instance
        {
            get
            {
                
                if (_instance == null)
                {
                    
                    _instance = new DataHandler();

                   
                    DataHandler.dBConnString = SWE_Assignment.Properties.Settings.Default.DBSourceString;

                }
                return _instance;
            }

        }
        
        public static string DBConnectionString
        {
            get
            {
                return dBConnString;
            }
        }


       
        public void openConnection()
        {        
            sqlconnector = new SqlConnection(dBConnString);

            sqlconnector.Open();
        }

        
        public void closeConnection()
        {
            
            sqlconnector.Close();
        }

        //This Method redirects the user to either the patient selection screen or the Management menu when they login depending.
        //if the User is a member of the medical staff they are redirected to the patient selection screen
        //if the user is a member of Management they are directed to the managment menu
        public int ValidateLogin(string username, string password)
        {
            
            //the query below finds the Username, password and management status of a user from the database.
            string query = $"SELECT Username, Password, Management, User_ID FROM Users WHERE Username = '{username}' AND Password = '{password}'";

            openConnection();//this calls the method to open the connector

            int boolValue;// this is the value that is returned(1 if the User is a manager and 0 if they are not)

            SqlCommand command = new SqlCommand(query, sqlconnector);

            using (SqlDataReader dataReader = command.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    string uName = dataReader.GetString(0);
                    string uPass = dataReader.GetString(1);
                    bool isMan = dataReader.GetBoolean(2);
                    boolValue = Convert.ToInt32(isMan);

                    HospitalRoom.StaffID = dataReader.GetInt32(4);

                    closeConnection();
                    return boolValue;
                }
                else
                {
                    closeConnection();
                    return -1;

                }
            }            
        }

        public void updateAlarmHistory()
        {

        }

        public void RegisterUser()
        {

        }

        public void DeregisterUser()
        {

        }

        public void GetPatientInfo( ref Bed patient, int patientNumber)
        {
            string query = "SELECT Patient_Name, Bedside_No, Age, Gender, Last_Name, NHS_Number FROM Patient WHERE Bedside_No = '{patientNumber}'";

            openConnection();

            SqlCommand command = new SqlCommand(query, sqlconnector);

            using (SqlDataReader dataReader = command.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    patient.PatientName = dataReader.GetString(0);
                    patient.BedsideNo = dataReader.GetInt32(1);
                    patient.Age = dataReader.GetInt32(2);
                    patient.Gender = dataReader.GetString(3);
                    patient.LastName = dataReader.GetString(4);
                    patient.NhsNumber = dataReader.GetString(5);

                }
            }

            closeConnection();
        }
    }
}

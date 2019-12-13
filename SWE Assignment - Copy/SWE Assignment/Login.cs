using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Assignment
{
    public partial class Login : Form
    {

        private bool dragging = false;
        private Point offset;
        private Point startPoint = new Point(0, 0);

        private static Login _instance;
        public static Login Instance
        {
            get
            {

                if (_instance == null)
                {
                    _instance = new Login();
                }
                return _instance;

            }
        }
        public Login()
        {
            InitializeComponent();
            password_txt.PasswordChar = '*';
            password_txt.MaxLength = 12;
            label3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                //getting the point to location
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //or
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this sets the values of these variables as the username and the password that the user inputs 
            string username = textBox2.Text;
            string password = password_txt.Text;


            int loginVerified = DataHandler.Instance.ValidateLogin(username, password);//this calls the method from the datahandler class


            //this if statement checks if the user is a manager or medical staff
            if (loginVerified == 1)
            {
                //if the value for loginverified is 1 then the user is directed to the Management Menu page
                ManagementMenu f5 = new ManagementMenu();
                f5.Show();
                Hide(); //this hides the login page (form 1)
            }
            else if (loginVerified == -1)
            {
                label3.Visible = true; //if the user enters the wrong username and password combination a prompt made visible, telling them to try again

            }
            else
            {
                //this else statement directs the user to the patient selection screen if the user is not a manager
                this.Hide();
                PatientSelection.PatientSelectionInstance.Show();
            }


            //this.Hide();
            //PatientSelection.PatientSelectionInstance.Show();

        }
    }
}

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
    public partial class PatientSelection : Form
    {
        public static string labelText = "";
        public PatientSelection()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            labelText = "BedSide 1";
            PatientMenu f9 = new PatientMenu();
            f9.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            labelText = "BedSide 2";
            PatientMenu f9 = new PatientMenu();
            f9.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            labelText = "BedSide 3";
            PatientMenu f9 = new PatientMenu();
            f9.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            labelText = "BedSide 4";
            PatientMenu f9 = new PatientMenu();
            f9.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            labelText = "BedSide 5";
            PatientMenu f9 = new PatientMenu();
            f9.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            labelText = "BedSide 6";
            PatientMenu f9 = new PatientMenu();
            f9.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            labelText = "BedSide 7";
            PatientMenu f9 = new PatientMenu();
            f9.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            labelText = "BedSide 8";
            PatientMenu f9 = new PatientMenu();
            f9.Show();
        }
    }
}

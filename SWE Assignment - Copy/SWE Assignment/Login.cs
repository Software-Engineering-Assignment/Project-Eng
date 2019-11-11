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
    public partial class Form1 : Form
    {

        private bool dragging = false;
        private Point offset;
        private Point startPoint = new Point(0, 0);

        public Form1()
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
            this.Hide();
            PatientSelection f2 = new PatientSelection();
            f2.Show();
        }
    }
}

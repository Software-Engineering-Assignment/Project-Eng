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
    public partial class ManagementMenu : Form
    {
        public ManagementMenu()
        {
            InitializeComponent();
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel7.Visible = true;
            panel6.Visible = true;
            panel7.BringToFront();
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = true;
            panel6.Visible = false;
            panel7.BringToFront();
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = true;
            panel8.Visible = true;
            panel6.Visible = false;
            panel8.BringToFront();
            panel9.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel6.Visible = false;
            panel9.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            this.Hide();
            Login.Instance.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }
    }
}

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
    public partial class AlarmPopup : Form
    {

        private static AlarmPopup _AlarmInstance;
        public static AlarmPopup AlarmInstance
        {
            get
            {
                if (_AlarmInstance == null)
                    _AlarmInstance = new AlarmPopup();
                return _AlarmInstance;
            }
        }
        public AlarmPopup()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void RaiseAlarm(int i)
        {
            switch (i)
            {
                case 1:
                    this.Hide();
                    panel2.BringToFront();
                    AlarmInstance.Show();
                    break;
                case 2:
                    panel1.BringToFront();
                    AlarmInstance.Show();
                    break;
            }
        }
    }
}

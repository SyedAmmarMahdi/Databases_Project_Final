using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vet_appointment
{
    public partial class appointment_history : Form
    {
        public appointment_history()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appointment ap = new Appointment();
            this.Close();
            ap.Show();
        }
    }
}

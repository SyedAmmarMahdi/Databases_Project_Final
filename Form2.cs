using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vet_appointment
{
    public partial class homepage : Form
    {

        public homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointment ap = new Appointment();
            ap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory inv = new Inventory();
            inv.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            vet emp = new vet();
            emp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            client clt = new client();
            clt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using Vet Appointment System!");
            this.Close();
        }
    }
}

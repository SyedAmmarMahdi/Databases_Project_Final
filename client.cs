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
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_new_client anc = new add_new_client();
            this.Close();
            anc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            view_clients vcl = new view_clients();
            this.Close();
            vcl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            homepage hp = new homepage();
            hp.Show();
        }
    }
}

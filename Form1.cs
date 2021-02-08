using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vet_appointment
{
    public partial class new_client : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LP74LG4\\SQLEXPRESS;Initial Catalog=Vet_Appointment_Mnagement_System;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
                       
        public new_client()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vet_Appointment_Mnagement_SystemDataSet);

        }

        private void new_client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vet_Appointment_Mnagement_SystemDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.vet_Appointment_Mnagement_SystemDataSet.Client);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

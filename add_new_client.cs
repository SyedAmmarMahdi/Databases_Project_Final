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
    public partial class add_new_client : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LP74LG4\\SQLEXPRESS;Initial Catalog=Vet_Appointment_Mnagement_System;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public add_new_client()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Client", con);
            adapt.Fill(dt);
            con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            client_nameTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";
            phone_numberTextBox.Text = "";
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vet_Appointment_Mnagement_SystemDataSet);

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            client cs = new client();
            this.Close();
            cs.Show();
        }

        private void idClientTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (client_nameTextBox.Text != "")
            {
                cmd = new SqlCommand("insert into client(client_name, email, address, phone_number) values(@name, @email, @address, @phone_number)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", client_nameTextBox.Text);
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                cmd.Parameters.AddWithValue("@phone_number", Convert.ToInt64(phone_numberTextBox.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void client_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

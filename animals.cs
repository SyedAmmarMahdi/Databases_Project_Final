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
    public partial class animals : Form
    {
        int client_id;

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LP74LG4\\SQLEXPRESS;Initial Catalog=Vet_Appointment_Mnagement_System;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;


        public animals(int c_id)
        {
            InitializeComponent();
            client_id = c_id;
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Animal", con);
            adapt.Fill(dt);
            con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            pet_nameTextBox.Text = "";
            speciesTextBox.Text = "";
            ageTextBox.Text = "";
            sexTextBox.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void animals_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            view_clients vc = new view_clients();
            this.Close();
            vc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pet_nameTextBox.Text != "")
            {
                cmd = new SqlCommand("insert into animal(Client_idClient, Pet_name, species, age, sex) values(@client_id, @pet_name, @species, @age, @sex)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@client_id", client_id);
                cmd.Parameters.AddWithValue("@pet_name", pet_nameTextBox.Text);
                cmd.Parameters.AddWithValue("@species", speciesTextBox.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(ageTextBox.Text));
                cmd.Parameters.AddWithValue("@sex", sexTextBox.Text);
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
}
}

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
    public partial class new_appointment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LP74LG4\\SQLEXPRESS;Initial Catalog=Vet_Appointment_Mnagement_System;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public new_appointment()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select client_name from Client";
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                client.Items.Add(rd[0]);
            }
            rd.Close();


            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;

            cmd1.CommandText = "Select Pet_name from Animal";
            cmd1.CommandType = CommandType.Text;
            SqlDataReader rd1 = cmd1.ExecuteReader();

            while (rd1.Read())
            {
                animal.Items.Add(rd1[0]);
            }
            rd1.Close();
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            animal.Items.Clear();
            con.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;

            cmd1.CommandText = "Select Pet_name from Animal where Client_idClient = (select idClient from Client where client_name='" + client.SelectedItem+"')";
            cmd1.CommandType = CommandType.Text;
            SqlDataReader rd1 = cmd1.ExecuteReader();

            while (rd1.Read())
            {
                animal.Items.Add(rd1[0]);
            }
            rd1.Close();
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Appointment ap = new Appointment();
            this.Close();
            ap.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //display member, value member binding
            cmd = new SqlCommand("insert into appointment(Animal_Client_idClient, animal_idanimal) values " +
                "((select idClient from Client where client_name='"+client.SelectedItem.ToString() +"')," +
                "(select idanimal from Animal where Pet_Name='" + animal.SelectedItem.ToString() + "'))", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");

            cmd.CommandText = "Select client_name from Client";
        }
    }
}

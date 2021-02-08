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
    public partial class view_animals : Form
    {
        int client_id;

        SqlConnection con;
        public view_animals(int c_id)
        {
            InitializeComponent();
            client_id = c_id;
            DisplayData();
        }

        private void DisplayData()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-LP74LG4\\SQLEXPRESS;Initial Catalog=Vet_Appointment_Mnagement_System;Integrated Security=True;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select idanimal, Pet_name, species, age, sex from Animal where Client_idClient = "+client_id;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "SearchResult");

            animal_grid.DataSource = ds.Tables["SearchResult"];
            animal_grid.Columns[0].ReadOnly = true;
            animal_grid.Columns[1].ReadOnly = true;
            animal_grid.Columns[2].ReadOnly = true;
            animal_grid.Columns[3].ReadOnly = true;
            animal_grid.Columns[4].ReadOnly = true;
            animal_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            animal_grid.MultiSelect = false;
            animal_grid.Refresh();
            animal_grid.Refresh();
        }

        private void view_animals_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            view_clients vc = new view_clients();
            this.Close();
            vc.Show();
        }
    }
}

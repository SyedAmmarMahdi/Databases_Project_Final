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
    public partial class view_clients : Form
    {
        SqlConnection con;
        int client_id;

        public view_clients()
        {   
            InitializeComponent();
            DisplayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayData()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-LP74LG4\\SQLEXPRESS;Initial Catalog=Vet_Appointment_Mnagement_System;Integrated Security=True;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from [Client]";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "SearchResult");

            client_grid.DataSource = ds.Tables["SearchResult"];
            client_grid.Columns[0].ReadOnly = true;
            client_grid.Columns[1].ReadOnly = true;
            client_grid.Columns[2].ReadOnly = true;
            client_grid.Columns[3].ReadOnly = true;
            client_grid.Columns[4].ReadOnly = true;
            client_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            client_grid.MultiSelect = false;
            client_grid.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client cl = new client();
            this.Close();
            cl.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            animals pet = new animals(Convert.ToInt32(client_grid.SelectedRows[0].Cells[0].Value));
            this.Close();
            pet.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            view_animals va = new view_animals(Convert.ToInt32(client_grid.SelectedRows[0].Cells[0].Value));
            this.Close();
            va.Show();
        }
    }
}

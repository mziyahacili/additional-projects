using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace AsanXidmetProject
{
    public partial class Form1 : Form
    {

        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataSet ds;

        public Form1()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder();
            builder.AddUserSecrets<Form1>();

            var config = builder.Build();

            var connectionString = config["DefaultConnection"];

            conn = new SqlConnection(connectionString);

            conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using SqlCommand cmd = new("select [name] from sys.tables", conn);
            using SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                dbComboBox.Items.Add(reader["name"]);
            }
        }

        private void getAllDatabtn_Click(object sender, EventArgs e)
        {
            if (dbComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select table first", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            adapter = new($"select * from {dbComboBox.SelectedItem.ToString()}", conn);

            DataSet ds = new();
            adapter.Fill(ds);

            dbDataGridView.DataSource = ds.Tables[0];
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using SqlCommandBuilder builder = new(adapter);

            DataTable table = (DataTable)dbDataGridView.DataSource;

            adapter.Update(table);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dbDataGridView.SelectedRows)
            {
                dbDataGridView.Rows.Remove(row);
            }

        }
    }
}

using MySql.Data.MySqlClient;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ContactMe
{
    public partial class Form1 : Form
    {

        string sqlstring = "server=localhost;uid=root;pwd=admin123;database=contacts";
        private int selectedId;
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            using (MySqlConnection connection = new MySqlConnection(sqlstring))
            {
                connection.Open();
                string sql = "INSERT INTO persons (name,email,phone) VALUES ('" + nameField.Text + "','" + emailField.Text + "','" + phoneField.Text + "') ";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {

                    cmd.Parameters.AddWithValue("@name", nameField.Text);
                    cmd.Parameters.AddWithValue("@email", emailField.Text);
                    cmd.Parameters.AddWithValue("@phone", phoneField.Text);

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Contact Added");
            DisplayInfo();

        }

        void DisplayInfo()
        {
            string sql = "SELECT * FROM persons";
            dataTable.Clear();
            using (MySqlConnection connection = new MySqlConnection(sqlstring))
            {
                MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayInfo();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            if (selectedId > 0)
            {
                using (MySqlConnection connection = new MySqlConnection(sqlstring))
                {
                    connection.Open();
                    string sql = "UPDATE persons SET name = @name, email = @email, phone = @phone WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", nameField.Text);
                        cmd.Parameters.AddWithValue("@email", emailField.Text);
                        cmd.Parameters.AddWithValue("@phone", phoneField.Text);
                        cmd.Parameters.AddWithValue("@id", selectedId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Contact Updated");
                DisplayInfo();
            }
            else
            {
                MessageBox.Show("You needs to select a contact.");
            }
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedId > 0)
            {
                using (MySqlConnection connection = new MySqlConnection(sqlstring))
                {
                    connection.Open();
                    string sql = "DELETE FROM persons WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Contact Deleted");
                        DisplayInfo();
                    }
                }
            }
            else
            {
                MessageBox.Show("You cannot delete without selecting the row");
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                nameField.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                emailField.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
                phoneField.Text = dataGridView1.Rows[e.RowIndex].Cells["phone"].Value.ToString();
            }
        }

        private void searchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dataTable.DefaultView;

            dv.RowFilter = "Name like '%" + searchField.Text + "%'";


        }
    }
}
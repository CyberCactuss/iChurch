using ChurchSystem.Database;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ChurchSystem.Dashboard_Forms.MembersFiles
{
    public partial class MembersMain : Form
    {
        private DatabaseConnection dbConnection;

        public MembersMain()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection("churchSystem.db");

            // Configure DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = dataGridView1.ClientSize.Height / 10;
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.Blue;
            headerStyle.Font = new Font("Century Gothic", 15, FontStyle.Bold);
            headerStyle.Padding = new Padding(0, 20, 0, 20);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;
            dataGridView1.DefaultCellStyle.Font = new Font("Yu Gothic", 11, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void MembersMain_Load(object sender, EventArgs e)
        {
            LoadMembersData(); 
        }

        private void LoadMembersData()
        {
            dbConnection.OpenConnection();
            dbConnection.LoadMembersIntoDataGridView(dataGridView1);
            dbConnection.CloseConnection();
        }

        private void MembersMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.CloseConnection();
        }

        private void guna2Button1_Click(object sender, EventArgs e) // ADD BUTTON
        {
            AddMember add = new AddMember();
            add.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e) // DELETE BUTTON
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                dataGridView1.Rows.Remove(selectedRow);
                DeleteRecordFromDatabase(selectedRow);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void DeleteRecordFromDatabase(DataGridViewRow selectedRow)
        {
            try
            {
                string name = selectedRow.Cells["Name"].Value?.ToString() ?? "";
                string email = selectedRow.Cells["Email"].Value?.ToString() ?? "";
                string sex = selectedRow.Cells["Sex"].Value?.ToString() ?? "";

                dbConnection.DeleteMemberDetails(name, email, sex);

                MessageBox.Show($"Member record with Name: {name}, Email: {email}, Sex: {sex} deleted successfully from the database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting record from the database: {ex.Message}");
                MessageBox.Show($"Error deleting record from the database: {ex.Message}");
            }
        }



        private void guna2Button3_Click(object sender, EventArgs e) // UPDATE BUTTON
        {
            LoadMembersData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

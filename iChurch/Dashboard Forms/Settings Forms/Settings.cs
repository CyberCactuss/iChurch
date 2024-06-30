using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChurchSystem.Database; // Ensure you have the appropriate using directive for the DatabaseConnection class

namespace ChurchSystem.Dashboard_Forms
{
    public partial class Settings : Form
    {
        private DatabaseConnection dbConnection;

        public Settings()   
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadUserCredentials();
            this.FormClosing += new FormClosingEventHandler(this.Settings_FormClosing);
        }

        private void InitializeDatabaseConnection()
        {
            dbConnection = new DatabaseConnection("churchSystem.db");
            dbConnection.OpenConnection();
        }

        private void LoadUserCredentials()
        {
            int userId = 1; 

            textBox1.Text = dbConnection.GetUsername(userId);
            textBox2.Text = dbConnection.GetPassword(userId);
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.CloseConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChurchSystem.Database;

namespace ChurchSystem
{
    public partial class LogIn : Form
    {
        private DatabaseConnection dbConnection;
        private AuthenticationService authenticationService;

        public LogIn()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection("churchSystem.db");
            authenticationService = new AuthenticationService(dbConnection);
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            guna2TextBox1.UseSystemPasswordChar = !guna2CheckBox1.Checked;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            string username = guna2TextBox3.Text;
            string password = guna2TextBox1.Text;

            //bool isValidCredentials = authenticationService.CheckCredentials(username, password);

            //if (isValidCredentials)
            //{               
            MainDashboard dashboardForm = new MainDashboard();
            dashboardForm.FormClosed += (s, args) => this.Close();
            this.Hide(); // Hide the current form
            dashboardForm.ShowDialog();
            //}
            /*else
            {

            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            guna2TextBox3.Clear();
            guna2TextBox1.Clear();
            }*/
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

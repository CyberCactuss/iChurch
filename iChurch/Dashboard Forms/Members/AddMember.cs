using ChurchSystem.Dashboard_Forms.Members;
using ChurchSystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSystem.Dashboard_Forms.MembersFiles
{
    public partial class AddMember : Form
    {
        private string name;
        private string email;
        private string age;
        private string sex;

        public AddMember()
        {
            InitializeComponent();
        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e) //CANCEL
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e) // PROCEED BUTTON
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
        string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (!IsValidEmail(textBox2.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please make a selection for all dropdowns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            name = textBox1.Text;
            email = textBox2.Text;
            age = comboBox1.SelectedItem.ToString(); 
            sex = comboBox2.SelectedItem.ToString();

            AddMember2 member2Form = new AddMember2(name, email, age, sex);
            member2Form.Owner = this;
            member2Form.FormClosed += (s, args) => this.Close();
            this.Hide();
            member2Form.ShowDialog();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // EMAIL TEXTBOX
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

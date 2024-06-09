using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing;
using System.Windows.Forms;

namespace ChurchSystem
{
    public partial class Dashboard : Form
    {
        private Dictionary<Guna2Button, Color> originalColors;
        public Dashboard()
        {
            InitializeComponent();
            originalColors = new Dictionary<Guna2Button, Color>
            {
                { guna2Button1, guna2Button1.FillColor },
                { guna2Button2, guna2Button2.FillColor },
                { guna2Button3, guna2Button3.FillColor },
                { guna2Button4, guna2Button4.FillColor },
                { guna2Button6, guna2Button6.FillColor },
                { guna2Button8, guna2Button8.FillColor }
            };
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = (Guna2Button)sender;


            foreach (var button in originalColors.Keys)
            {
                button.FillColor = originalColors[button];
            }

            // Change color for the clicked button
            clickedButton.FillColor = Color.LightGray;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();

            login.Show();

            this.Hide();
        }


        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();

            login.Show();

            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
using ChurchSystem.Dashboard_Forms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSystem
{
    public partial class MainDashboard : Form
    {
        private Dictionary<Guna2Button, Color> originalColors;
        private Form? currentChildForm = null;

        private LogIn login = new LogIn();
        private Events eventsForm;
        private Home homeForm;
        private Inventory inventoryForm;
        private Dashboard_Forms.MembersFiles.MembersMain membersForm;
        private Finance financeForm;
        private Settings settingsForm;

        public MainDashboard()
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

            eventsForm = new Events();
            homeForm = new Home();
            inventoryForm = new Inventory();
            membersForm = new Dashboard_Forms.MembersFiles.MembersMain();
            financeForm = new Finance();
            settingsForm = new Settings();

            ShowChildForm(homeForm);
            guna2Button8.FillColor = Color.LightGray;
        }


        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = (Guna2Button)sender;


            foreach (var button in originalColors.Keys)
            {
                button.FillColor = originalColors[button];
            }

            clickedButton.FillColor = Color.LightGray;

            switch (clickedButton.Name)
            {
                case "guna2Button1": // Inventory Button
                    ShowChildForm(inventoryForm);
                    break;
                case "guna2Button2": // Events Button
                    ShowChildForm(eventsForm);
                    break;
                case "guna2Button3": // Members Button
                    ShowChildForm(membersForm);
                    break;
                case "guna2Button4": // Finance Button
                    ShowChildForm(financeForm);
                    break;
                case "guna2Button6": // Settings Button
                    ShowChildForm(settingsForm);
                    break;
                case "guna2Button8": // Home Button
                    ShowChildForm(homeForm);
                    break;
                default:
                    break;
            }
        }

        private void ShowChildForm(Form childForm)
        {
            
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e) // HOME BUTTON
        {
            Button_Click(sender, e);
        }

        private void guna2Button4_Click(object sender, EventArgs e) // FINANCE BUTTON
        {
            Button_Click(sender, e);
        }

        private void guna2Button1_Click(object sender, EventArgs e) // INVENTORY BUTTON
        {
            Button_Click(sender, e);
        }

        private void guna2Button2_Click(object sender, EventArgs e) // EVENTS BUTTON
        {
            Button_Click(sender, e);
        }

        private void guna2Button3_Click(object sender, EventArgs e) // MEMBERS BUTTON
        {
            Button_Click(sender, e);
        }

        private void guna2Button6_Click(object sender, EventArgs e) // SETTINGS BUTTON
        {
            Button_Click(sender, e);
        }

        private void guna2Button9_Click(object sender, EventArgs e) // LOG OUT BUTTON
        {
            login.FormClosed += (s, args) => this.Close();
            this.Hide(); 
            login.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

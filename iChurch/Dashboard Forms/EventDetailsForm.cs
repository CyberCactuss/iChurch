using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSystem.Dashboard_Forms.Members
{
    public partial class EventDetailsForm : Form
    {
        private string eventName;
        private string eventDateTime;
        private DateTime selectedDate;
        private Color eventColor;
        private Panel panel5;

        public TextBox EventNameTextBox => txteventname;
        public TextBox EventDateTextBox => txtdate;
        public ComboBox EventTimeComboBox => cmbtime;

    

        public EventDetailsForm(DateTime date, Color eventColor, Panel panel5)
        {
            InitializeComponent();
            selectedDate = date;
            this.eventColor = eventColor;
            this.panel5 = panel5;
            SetSelectedDate(selectedDate);
        
        }

        public void SetSelectedDate(DateTime date)
        {
            selectedDate = date;
            txtdate.Text = selectedDate.ToString("MMMM dd, yyyy");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
        }

        private void EventDetailsForm_Load(object sender, EventArgs e)
        {
            panel4.BackColor = eventColor;
            SetSelectedDate(selectedDate);
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to create this event?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {

                CreateEvent(eventColor);
            }
        }

        private void CreateEvent(Color eventColor)
        {
            string eventName = EventNameTextBox.Text;
            string eventDate = EventDateTextBox.Text;
            string eventTime = EventTimeComboBox.SelectedItem?.ToString();
            if (eventName != null && eventDate != null && eventTime != null)
            {
                string eventDateTime = $"{eventDate}, {eventTime}";


                Button newButton = new Button();
                newButton.Text = $"{eventName}\n{eventDateTime}";
                newButton.Font = new Font("Palatino Linotype", 18, FontStyle.Regular);
                newButton.Width = 600;
                newButton.Height = 90;
                newButton.FlatStyle = FlatStyle.Flat;
                newButton.TextAlign = ContentAlignment.MiddleLeft;
                newButton.FlatStyle = FlatStyle.Flat;
                newButton.Margin = new Padding(5);

                newButton.BackColor = eventColor;
                newButton.Click += (sender, e) =>
                {

                    EventDetailsForm eventDetailsForm = new EventDetailsForm(selectedDate, eventColor, panel5);
                    eventDetailsForm.EventNameTextBox.Text = eventName;
                    eventDetailsForm.EventDateTextBox.Text = eventDate;
                    eventDetailsForm.EventTimeComboBox.SelectedItem = eventTime;
                    eventDetailsForm.ShowDialog();
                };

                panel5.Controls.Add(newButton);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form form in Application.OpenForms)
            {
                if (form is Events)
                {
                    form.Visible = true;
                    break;
                }
            }
        }

       
    }
}
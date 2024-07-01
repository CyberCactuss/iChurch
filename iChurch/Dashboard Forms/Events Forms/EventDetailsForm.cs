using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private ContextMenuStrip optionsMenu;
        private Button newButton;

        public TextBox EventNameTextBox => txteventname;
        public TextBox EventDateTextBox => txtdate;
        public ComboBox EventTimeComboBox => cmbtime;


        public EventDetailsForm(DateTime date, Color eventColor, Panel panel5)
        {
            InitializeComponent();

     
            selectedDate = date;
            this.eventColor = eventColor;
            this.panel5 = panel5;
            txtdate.Text = selectedDate.ToString("yyyy-MM-dd");
            SetSelectedDate(selectedDate);

 
            optionsMenu = new ContextMenuStrip();
            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Edit");
            ToolStripMenuItem menuItem2 = new ToolStripMenuItem("Delete");
            ToolStripMenuItem menuItem3 = new ToolStripMenuItem("Save");

            menuItem1.Click += EditEvent_Click;
            menuItem2.Click += DeleteEvent_Click;
            menuItem3.Click += SaveEvent_Click;

            optionsMenu.Items.Add(menuItem1);
            optionsMenu.Items.Add(menuItem2);
            optionsMenu.Items.Add(menuItem3);

            button2.ContextMenuStrip = optionsMenu;
            button2.Click += button2_Click;
        }
        private void EditEvent_Click(object sender, EventArgs e)
        {
      
            EventNameTextBox.ReadOnly = false;
            EventDateTextBox.ReadOnly = false;
            EventTimeComboBox.Enabled = true;
        }

        private void DeleteEvent_Click(object sender, EventArgs e)
        {
    
            Button eventButton = FindEventButton(panel5);
            if (eventButton != null)
            {
                panel5.Controls.Remove(eventButton);
            }
            this.Close();
        }

        private void SaveEvent_Click(object sender, EventArgs e)
        {
     
            string eventName = EventNameTextBox.Text;
            string eventDate = EventDateTextBox.Text;
            string eventTime = EventTimeComboBox.SelectedItem?.ToString();
            string eventVenue = txtvenue.Text; 
            string eventType = txttype.Text;   

        
            if (newButton != null)
            {
                newButton.Text = $"{eventName}\n{eventDate} {eventTime}\n{eventVenue}\n{eventType}";
            }

            EventNameTextBox.ReadOnly = true;
            EventDateTextBox.ReadOnly = true;
            EventTimeComboBox.Enabled = false;

            optionsMenu.Items.Clear();
            optionsMenu.Items.Add(new ToolStripMenuItem("Edit", null, EditEvent_Click));
            optionsMenu.Items.Add(new ToolStripMenuItem("Delete", null, DeleteEvent_Click));
        }




        private Button FindEventButton(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Button button && button.Tag == this)
                {
                    return button;
                }
            }
            return null;
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

        private static int nextButtonTop = 10;

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to create this event?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                string eventName = txteventname.Text;
                string eventDate = txtdate.Text;
                string eventTime = cmbtime.SelectedItem?.ToString();
                string eventVenue = txtvenue.Text;
                string eventType = txttype.Text;
                Color eventColor = this.eventColor;

                CreateEventButton(eventName, eventDate, eventTime, eventVenue, eventType, eventColor);

                this.Close();
            }
        }

        private void CreateEventButton(string eventName, string eventDate, string eventTime, string eventVenue, string eventType, Color eventColor)
        {
           
            newButton = new Button();
            newButton.Size = new Size(590, 100);
            newButton.Location = new Point(10, nextButtonTop);
            newButton.BackColor = eventColor;
            newButton.Font = new Font("Arial", 12, FontStyle.Regular | FontStyle.Italic);
            newButton.Tag = this;

            newButton.Text = $"{eventName}\n{eventDate} {eventTime}\n{eventVenue}\n{eventType}";

            newButton.Click += (sender, e) =>
            {
             
                EventDetailsForm eventDetailsForm = new EventDetailsForm(selectedDate, eventColor, panel5);
                eventDetailsForm.EventNameTextBox.Text = eventName;
                eventDetailsForm.EventDateTextBox.Text = eventDate;
                eventDetailsForm.EventTimeComboBox.SelectedItem = eventTime;
                eventDetailsForm.EventNameTextBox.ReadOnly = true;
                eventDetailsForm.EventDateTextBox.ReadOnly = true;
                eventDetailsForm.EventTimeComboBox.Enabled = false;
                eventDetailsForm.ShowDialog();
            };

      
            ContextMenuStrip eventButtonMenu = new ContextMenuStrip();
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Edit");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
            ToolStripMenuItem saveMenuItem = new ToolStripMenuItem("Save");

            editMenuItem.Click += (sender, e) =>
            {
                EventNameTextBox.Text = eventName;
                EventDateTextBox.Text = eventDate;
                EventTimeComboBox.SelectedItem = eventTime;

                EventNameTextBox.ReadOnly = false;
                EventDateTextBox.ReadOnly = false;
                EventTimeComboBox.Enabled = true;
            };

            saveMenuItem.Click += SaveEvent_Click;
            deleteMenuItem.Click += (sender, e) =>
            {
                panel5.Controls.Remove(newButton);
                foreach (Control control in panel5.Controls)
                {
                    if (control is Button button && button.Top > newButton.Top)
                    {
                        button.Top -= newButton.Height + 10;
                    }
                }
                nextButtonTop -= newButton.Height + 10;

                this.Close();
            };

            eventButtonMenu.Items.Add(editMenuItem);
            eventButtonMenu.Items.Add(saveMenuItem);
            eventButtonMenu.Items.Add(deleteMenuItem);

            newButton.ContextMenuStrip = eventButtonMenu;
            panel5.Controls.Add(newButton);
            nextButtonTop += newButton.Height + 10;
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

        private void button2_Click(object sender, EventArgs e)
        {
            optionsMenu.Show(button2, new Point(0, button2.Height));
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

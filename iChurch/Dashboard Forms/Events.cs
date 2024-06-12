using ChurchSystem.Dashboard_Forms.Members;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChurchSystem.Dashboard_Forms
{
    public partial class Events : Form
    {
        private int month;
        private int year;
        

        public Events()
        {
            InitializeComponent();
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            SetMonthYearLabel();
            btnnext.Click += btnNext_Click;
            btnprevious.Click += btnPrevious_Click;   

        }

        private void SetMonthYearLabel()
        {
            textBox1.Text = $"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)} {year}";
            PopulateDays();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            SetMonthYearLabel();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            SetMonthYearLabel();
        }

        private void PopulateDays()
        {
            flowLayoutPanel1.Controls.Clear();

            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            int startingDayOffset = (int)firstDayOfMonth.DayOfWeek;

            int daysInMonth = DateTime.DaysInMonth(year, month);
            int buttonWidth = flowLayoutPanel1.ClientSize.Width / 8;
            int buttonHeight = flowLayoutPanel1.ClientSize.Height / 7;

            for (int day = 1; day <= 42; day++)
            {
                Button button1 = new Button();
                button1.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                button1.Margin = new Padding(1);

                if (day <= startingDayOffset || day > daysInMonth + startingDayOffset)
                {
                    button1.Enabled = false;
                    button1.BackColor = System.Drawing.Color.LightGray;
                    button1.Font = new System.Drawing.Font("Helvetica", 12, System.Drawing.FontStyle.Regular);
                    button1.ForeColor = System.Drawing.Color.Gray;

                    if (day <= startingDayOffset)
                        button1.Text = (daysInMonth - startingDayOffset + day).ToString();
                    else
                        button1.Text = (day - (daysInMonth + startingDayOffset)).ToString();
                }
                else
                {
                    int currentDay = day - startingDayOffset;
                    button1.Text = currentDay.ToString();
                    button1.BackColor = System.Drawing.Color.White;
                    button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    button1.FlatAppearance.BorderSize = 1;
                    button1.Font = new System.Drawing.Font("Helvetica", 12, System.Drawing.FontStyle.Regular);


                    if (currentDay == DateTime.Now.Day && month == DateTime.Now.Month && year == DateTime.Now.Year)
                    {
                        button1.BackColor = System.Drawing.Color.LightBlue;
                        button1.ForeColor = System.Drawing.Color.Black;
                    }
                }

                button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                flowLayoutPanel1.Controls.Add(button1);
                
            }
        }

        private Color GenerateRandomColor()
        {
            Random random = new Random();
            int red = random.Next(128, 256);
            int blue = random.Next(128, 256);
            int green = random.Next(128, 256);

            return Color.FromArgb(red, green, blue);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTime.Today;
            Color eventColor = GenerateRandomColor();
            EventDetailsForm eventDetailsForm = new EventDetailsForm(selectedDate, eventColor, panel5);
            eventDetailsForm.ShowDialog();
            eventDetailsForm.SetSelectedDate(selectedDate); ;
        }
        
    }
}

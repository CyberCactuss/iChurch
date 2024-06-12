namespace ChurchSystem.Dashboard_Forms.Members
{
    partial class EventDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel4 = new Panel();
            button2 = new Button();
            txttype = new TextBox();
            txtdescription = new TextBox();
            txtvenue = new TextBox();
            txtdate = new TextBox();
            cmbtime = new ComboBox();
            label9 = new Label();
            txteventname = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnadd = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txttype);
            panel1.Controls.Add(txtdescription);
            panel1.Controls.Add(txtvenue);
            panel1.Controls.Add(txtdate);
            panel1.Controls.Add(cmbtime);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txteventname);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 624);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(button2);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(910, 62);
            panel4.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(856, 7);
            button2.Name = "button2";
            button2.Size = new Size(44, 48);
            button2.TabIndex = 0;
            button2.Text = "DOT\r\n";
            button2.UseVisualStyleBackColor = true;
            // 
            // txttype
            // 
            txttype.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttype.Location = new Point(462, 201);
            txttype.Name = "txttype";
            txttype.Size = new Size(431, 31);
            txttype.TabIndex = 16;
            // 
            // txtdescription
            // 
            txtdescription.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdescription.Location = new Point(8, 439);
            txtdescription.Multiline = true;
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(885, 178);
            txtdescription.TabIndex = 15;
            // 
            // txtvenue
            // 
            txtvenue.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtvenue.Location = new Point(5, 282);
            txtvenue.Name = "txtvenue";
            txtvenue.Size = new Size(730, 31);
            txtvenue.TabIndex = 13;
            // 
            // txtdate
            // 
            txtdate.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdate.Location = new Point(462, 359);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(302, 31);
            txtdate.TabIndex = 12;
            // 
            // cmbtime
            // 
            cmbtime.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbtime.FormattingEnabled = true;
            cmbtime.Items.AddRange(new object[] { "12:00 AM ", "1:00 AM", "2:00 AM", "3:00 AM", "4:00 AM", "5:00 AM", "6:00 AM", "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM ", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM", "8:00 PM", "9:00 PM", "10:00 PM", "11:00 PM" });
            cmbtime.Location = new Point(8, 359);
            cmbtime.Name = "cmbtime";
            cmbtime.Size = new Size(302, 29);
            cmbtime.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(462, 164);
            label9.Name = "label9";
            label9.Size = new Size(146, 25);
            label9.TabIndex = 7;
            label9.Text = "Type of Event";
            // 
            // txteventname
            // 
            txteventname.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txteventname.Location = new Point(8, 201);
            txteventname.Name = "txteventname";
            txteventname.Size = new Size(416, 31);
            txteventname.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 411);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 6;
            label8.Text = "Summary\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 254);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 4;
            label6.Text = "Venue";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(462, 331);
            label5.Name = "label5";
            label5.Size = new Size(184, 25);
            label5.TabIndex = 3;
            label5.Text = "Date of the Event";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 331);
            label4.Name = "label4";
            label4.Size = new Size(185, 25);
            label4.TabIndex = 2;
            label4.Text = "Time of the event";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 164);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 1;
            label3.Text = "Event's Name";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(587, 631);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(310, 51);
            btnadd.TabIndex = 4;
            btnadd.Text = "Create an Event";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(117, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            deleteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem1 });
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(116, 22);
            deleteToolStripMenuItem.Text = "Options";
            // 
            // button1
            // 
            button1.Location = new Point(4, 631);
            button1.Name = "button1";
            button1.Size = new Size(310, 51);
            button1.TabIndex = 5;
            button1.Text = "Back to Event List\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(180, 22);
            deleteToolStripMenuItem1.Text = "Delete";
            // 
            // EventDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 694);
            Controls.Add(button1);
            Controls.Add(btnadd);
            Controls.Add(panel1);
            Name = "EventDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventDetailsForm";
            Load += EventDetailsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txteventname;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private TextBox txtvenue;
        private TextBox txtdate;
        private ComboBox cmbtime;
        private TextBox txtdescription;
        private Button btnadd;
        private Panel panel4;
        private TextBox txttype;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button button2;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
    }
}
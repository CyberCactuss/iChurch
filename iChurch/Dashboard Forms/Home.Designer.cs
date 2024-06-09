namespace ChurchSystem.Dashboard_Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox3 = new PictureBox();
            guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            label6 = new Label();
            label5 = new Label();
            roundPanel1 = new Tools.RoundPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.DodgerBlue;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(588, 52);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(242, 205);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // guna2Button7
            // 
            guna2Button7.Animated = true;
            guna2Button7.AutoRoundedCorners = true;
            guna2Button7.BackColor = Color.DodgerBlue;
            guna2Button7.BorderRadius = 26;
            guna2Button7.CustomizableEdges = customizableEdges1;
            guna2Button7.DisabledState.BorderColor = Color.DarkGray;
            guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button7.FillColor = Color.White;
            guna2Button7.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button7.ForeColor = Color.DodgerBlue;
            guna2Button7.Location = new Point(82, 190);
            guna2Button7.Name = "guna2Button7";
            guna2Button7.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button7.Size = new Size(171, 54);
            guna2Button7.TabIndex = 20;
            guna2Button7.Text = "Start Now";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DodgerBlue;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(77, 117);
            label6.Name = "label6";
            label6.Size = new Size(176, 28);
            label6.TabIndex = 19;
            label6.Text = "Come with us!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DodgerBlue;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(77, 71);
            label5.Name = "label5";
            label5.Size = new Size(366, 28);
            label5.TabIndex = 18;
            label5.Text = "Need a management system?";
            // 
            // roundPanel1
            // 
            roundPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundPanel1.BackColor = Color.DodgerBlue;
            roundPanel1.Location = new Point(37, 35);
            roundPanel1.Name = "roundPanel1";
            roundPanel1.Size = new Size(831, 247);
            roundPanel1.TabIndex = 17;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(909, 694);
            Controls.Add(pictureBox3);
            Controls.Add(guna2Button7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(roundPanel1);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Label label6;
        private Label label5;
        private Tools.RoundPanel roundPanel1;
    }
}
namespace AutoClicker
{
    partial class GalaxyClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalaxyClicker));
            this.numMouseClicks = new System.Windows.Forms.Label();
            this.MouseYLabel = new System.Windows.Forms.Label();
            this.MouseXLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.asdfas = new System.Windows.Forms.Label();
            this.logInButton1 = new LoginTheme.LogInButton();
            this.logInButton2 = new LoginTheme.LogInButton();
            this.maxWait = new Guna.UI2.WinForms.Guna2TextBox();
            this.minWait = new Guna.UI2.WinForms.Guna2TextBox();
            this.maxClicksBetweenMovement = new Guna.UI2.WinForms.Guna2TextBox();
            this.minClicksBetweenMovement = new Guna.UI2.WinForms.Guna2TextBox();
            this.startButton = new Guna.UI2.WinForms.Guna2Button();
            this.stopbutton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numMouseClicks
            // 
            this.numMouseClicks.AutoSize = true;
            this.numMouseClicks.BackColor = System.Drawing.Color.Transparent;
            this.numMouseClicks.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.numMouseClicks.Location = new System.Drawing.Point(467, 287);
            this.numMouseClicks.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.numMouseClicks.Name = "numMouseClicks";
            this.numMouseClicks.Size = new System.Drawing.Size(106, 13);
            this.numMouseClicks.TabIndex = 25;
            this.numMouseClicks.Text = "0 Total Mouse Clicks";
            this.numMouseClicks.Click += new System.EventHandler(this.numMouseClicks_Click);
            // 
            // MouseYLabel
            // 
            this.MouseYLabel.AutoSize = true;
            this.MouseYLabel.BackColor = System.Drawing.Color.Transparent;
            this.MouseYLabel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.MouseYLabel.Location = new System.Drawing.Point(228, 287);
            this.MouseYLabel.Name = "MouseYLabel";
            this.MouseYLabel.Size = new System.Drawing.Size(95, 13);
            this.MouseYLabel.TabIndex = 24;
            this.MouseYLabel.Text = "Mouse Y Position: ";
            this.MouseYLabel.Click += new System.EventHandler(this.MouseYLabel_Click);
            // 
            // MouseXLabel
            // 
            this.MouseXLabel.AutoSize = true;
            this.MouseXLabel.BackColor = System.Drawing.Color.Transparent;
            this.MouseXLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MouseXLabel.Location = new System.Drawing.Point(37, 287);
            this.MouseXLabel.Name = "MouseXLabel";
            this.MouseXLabel.Size = new System.Drawing.Size(95, 13);
            this.MouseXLabel.TabIndex = 23;
            this.MouseXLabel.Text = "Mouse X Position: ";
            this.MouseXLabel.Click += new System.EventHandler(this.MouseXLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(365, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Max Clicks Before Movement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(133, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Min Clicks Before Movement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(167, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Max Wait (ms)";
            // 
            // asdfas
            // 
            this.asdfas.AutoSize = true;
            this.asdfas.BackColor = System.Drawing.Color.Transparent;
            this.asdfas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.asdfas.Location = new System.Drawing.Point(405, 98);
            this.asdfas.Name = "asdfas";
            this.asdfas.Size = new System.Drawing.Size(71, 13);
            this.asdfas.TabIndex = 18;
            this.asdfas.Text = "Min Wait (ms)";
            // 
            // logInButton1
            // 
            this.logInButton1.BackColor = System.Drawing.Color.Transparent;
            this.logInButton1.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logInButton1.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logInButton1.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInButton1.HoverColour = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.logInButton1.Location = new System.Drawing.Point(607, 5);
            this.logInButton1.Name = "logInButton1";
            this.logInButton1.PressedColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.logInButton1.ProgressColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.logInButton1.Size = new System.Drawing.Size(40, 34);
            this.logInButton1.TabIndex = 26;
            this.logInButton1.Text = "X";
            this.logInButton1.Click += new System.EventHandler(this.logInButton1_Click);
            // 
            // logInButton2
            // 
            this.logInButton2.BackColor = System.Drawing.Color.Transparent;
            this.logInButton2.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logInButton2.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logInButton2.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInButton2.HoverColour = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.logInButton2.Location = new System.Drawing.Point(569, 12);
            this.logInButton2.Name = "logInButton2";
            this.logInButton2.PressedColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.logInButton2.ProgressColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.logInButton2.Size = new System.Drawing.Size(40, 34);
            this.logInButton2.TabIndex = 27;
            this.logInButton2.Text = "-";
            this.logInButton2.Click += new System.EventHandler(this.logInButton2_Click);
            // 
            // maxWait
            // 
            this.maxWait.BorderRadius = 15;
            this.maxWait.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maxWait.DefaultText = "";
            this.maxWait.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.maxWait.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.maxWait.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maxWait.DisabledState.Parent = this.maxWait;
            this.maxWait.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maxWait.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maxWait.FocusedState.Parent = this.maxWait;
            this.maxWait.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maxWait.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maxWait.HoverState.Parent = this.maxWait;
            this.maxWait.Location = new System.Drawing.Point(125, 115);
            this.maxWait.Name = "maxWait";
            this.maxWait.PasswordChar = '\0';
            this.maxWait.PlaceholderText = "";
            this.maxWait.SelectedText = "";
            this.maxWait.ShadowDecoration.Parent = this.maxWait;
            this.maxWait.Size = new System.Drawing.Size(160, 37);
            this.maxWait.TabIndex = 28;
            // 
            // minWait
            // 
            this.minWait.BorderRadius = 15;
            this.minWait.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.minWait.DefaultText = "";
            this.minWait.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.minWait.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.minWait.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.minWait.DisabledState.Parent = this.minWait;
            this.minWait.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.minWait.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.minWait.FocusedState.Parent = this.minWait;
            this.minWait.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minWait.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.minWait.HoverState.Parent = this.minWait;
            this.minWait.Location = new System.Drawing.Point(360, 118);
            this.minWait.Name = "minWait";
            this.minWait.PasswordChar = '\0';
            this.minWait.PlaceholderText = "";
            this.minWait.SelectedText = "";
            this.minWait.ShadowDecoration.Parent = this.minWait;
            this.minWait.Size = new System.Drawing.Size(160, 37);
            this.minWait.TabIndex = 29;
            // 
            // maxClicksBetweenMovement
            // 
            this.maxClicksBetweenMovement.BackColor = System.Drawing.Color.Transparent;
            this.maxClicksBetweenMovement.BorderRadius = 15;
            this.maxClicksBetweenMovement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maxClicksBetweenMovement.DefaultText = "";
            this.maxClicksBetweenMovement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.maxClicksBetweenMovement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.maxClicksBetweenMovement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maxClicksBetweenMovement.DisabledState.Parent = this.maxClicksBetweenMovement;
            this.maxClicksBetweenMovement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maxClicksBetweenMovement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maxClicksBetweenMovement.FocusedState.Parent = this.maxClicksBetweenMovement;
            this.maxClicksBetweenMovement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maxClicksBetweenMovement.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maxClicksBetweenMovement.HoverState.Parent = this.maxClicksBetweenMovement;
            this.maxClicksBetweenMovement.Location = new System.Drawing.Point(360, 174);
            this.maxClicksBetweenMovement.Name = "maxClicksBetweenMovement";
            this.maxClicksBetweenMovement.PasswordChar = '\0';
            this.maxClicksBetweenMovement.PlaceholderText = "";
            this.maxClicksBetweenMovement.SelectedText = "";
            this.maxClicksBetweenMovement.ShadowDecoration.Parent = this.maxClicksBetweenMovement;
            this.maxClicksBetweenMovement.Size = new System.Drawing.Size(160, 37);
            this.maxClicksBetweenMovement.TabIndex = 30;
            // 
            // minClicksBetweenMovement
            // 
            this.minClicksBetweenMovement.BorderRadius = 15;
            this.minClicksBetweenMovement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.minClicksBetweenMovement.DefaultText = "";
            this.minClicksBetweenMovement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.minClicksBetweenMovement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.minClicksBetweenMovement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.minClicksBetweenMovement.DisabledState.Parent = this.minClicksBetweenMovement;
            this.minClicksBetweenMovement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.minClicksBetweenMovement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.minClicksBetweenMovement.FocusedState.Parent = this.minClicksBetweenMovement;
            this.minClicksBetweenMovement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minClicksBetweenMovement.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.minClicksBetweenMovement.HoverState.Parent = this.minClicksBetweenMovement;
            this.minClicksBetweenMovement.Location = new System.Drawing.Point(125, 174);
            this.minClicksBetweenMovement.Name = "minClicksBetweenMovement";
            this.minClicksBetweenMovement.PasswordChar = '\0';
            this.minClicksBetweenMovement.PlaceholderText = "";
            this.minClicksBetweenMovement.SelectedText = "";
            this.minClicksBetweenMovement.ShadowDecoration.Parent = this.minClicksBetweenMovement;
            this.minClicksBetweenMovement.Size = new System.Drawing.Size(160, 37);
            this.minClicksBetweenMovement.TabIndex = 31;
            // 
            // startButton
            // 
            this.startButton.CheckedState.Parent = this.startButton;
            this.startButton.CustomImages.Parent = this.startButton;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.HoverState.Parent = this.startButton;
            this.startButton.Location = new System.Drawing.Point(125, 222);
            this.startButton.Name = "startButton";
            this.startButton.ShadowDecoration.Parent = this.startButton;
            this.startButton.Size = new System.Drawing.Size(180, 45);
            this.startButton.TabIndex = 32;
            this.startButton.Text = "Start Auto Clicker";
            this.startButton.Click += new System.EventHandler(this.startButton_Click_2);
            // 
            // stopbutton
            // 
            this.stopbutton.CheckedState.Parent = this.stopbutton;
            this.stopbutton.CustomImages.Parent = this.stopbutton;
            this.stopbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stopbutton.ForeColor = System.Drawing.Color.White;
            this.stopbutton.HoverState.Parent = this.stopbutton;
            this.stopbutton.Location = new System.Drawing.Point(351, 222);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.ShadowDecoration.Parent = this.stopbutton;
            this.stopbutton.Size = new System.Drawing.Size(180, 45);
            this.stopbutton.TabIndex = 33;
            this.stopbutton.Text = "Stop Auto Clicker";
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click_2);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.logInButton2);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-5, -7);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(655, 83);
            this.guna2GradientPanel1.TabIndex = 34;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            this.guna2GradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2GradientPanel1_MouseDown);
            this.guna2GradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2GradientPanel1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(131, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(425, 55);
            this.label4.TabIndex = 35;
            this.label4.Text = "Auto Clicker V 1.7";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label4_MouseMove);
            // 
            // GalaxyClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 308);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.minClicksBetweenMovement);
            this.Controls.Add(this.maxClicksBetweenMovement);
            this.Controls.Add(this.minWait);
            this.Controls.Add(this.maxWait);
            this.Controls.Add(this.logInButton1);
            this.Controls.Add(this.numMouseClicks);
            this.Controls.Add(this.MouseYLabel);
            this.Controls.Add(this.MouseXLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.asdfas);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GalaxyClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GalaxyClicker";
            this.Load += new System.EventHandler(this.AutoClicker_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AutoClicker_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AutoClicker_MouseMove);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numMouseClicks;
        private System.Windows.Forms.Label MouseYLabel;
        private System.Windows.Forms.Label MouseXLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label asdfas;
        private LoginTheme.LogInButton logInButton1;
        private LoginTheme.LogInButton logInButton2;
        private Guna.UI2.WinForms.Guna2TextBox maxWait;
        private Guna.UI2.WinForms.Guna2TextBox minWait;
        private Guna.UI2.WinForms.Guna2TextBox maxClicksBetweenMovement;
        private Guna.UI2.WinForms.Guna2TextBox minClicksBetweenMovement;
        private Guna.UI2.WinForms.Guna2Button startButton;
        private Guna.UI2.WinForms.Guna2Button stopbutton;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label4;
    }
}


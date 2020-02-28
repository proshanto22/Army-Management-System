namespace Army_Management_System
{
    partial class AppBody
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
            this.components = new System.ComponentModel.Container();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SlidingPanel_Timer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SlidingPanel_ToggleButton = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.SteelBlue;
            this.TitleBar.Controls.Add(this.MinimizeButton);
            this.TitleBar.Controls.Add(this.LogOffButton);
            this.TitleBar.Controls.Add(this.closeButton);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.ForeColor = System.Drawing.Color.Maroon;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(814, 26);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Azure;
            this.MinimizeButton.BackgroundImage = global::Army_Management_System.Properties.Resources.iconfinder_minimize_36516;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.Lavender;
            this.MinimizeButton.Location = new System.Drawing.Point(765, 1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(21, 22);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // LogOffButton
            // 
            this.LogOffButton.BackColor = System.Drawing.Color.LightCyan;
            this.LogOffButton.BackgroundImage = global::Army_Management_System.Properties.Resources.iconfinder_40_Close_Switch_Off_Power_Switcher_Button_2142692;
            this.LogOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOffButton.ForeColor = System.Drawing.Color.Lavender;
            this.LogOffButton.Location = new System.Drawing.Point(740, 1);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(21, 22);
            this.LogOffButton.TabIndex = 2;
            this.LogOffButton.UseVisualStyleBackColor = false;
            this.LogOffButton.Click += new System.EventHandler(this.LogOffButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Azure;
            this.closeButton.BackgroundImage = global::Army_Management_System.Properties.Resources.iconfinder_Close_1891023;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Lavender;
            this.closeButton.Location = new System.Drawing.Point(790, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 22);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SlidingPanel_Timer
            // 
            this.SlidingPanel_Timer.Interval = 50;
            this.SlidingPanel_Timer.Tick += new System.EventHandler(this.SlidingPanel_Timer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(150, 26);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(664, 520);
            this.ContentPanel.TabIndex = 2;
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SlidingPanel.BackgroundImage = global::Army_Management_System.Properties.Resources.blue_light_abstract_background_business_brochure_vector_4521263;
            this.SlidingPanel.Controls.Add(this.AboutButton);
            this.SlidingPanel.Controls.Add(this.HelpButton);
            this.SlidingPanel.Controls.Add(this.SearchButton);
            this.SlidingPanel.Controls.Add(this.HomeButton);
            this.SlidingPanel.Controls.Add(this.SlidingPanel_ToggleButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 26);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(150, 520);
            this.SlidingPanel.TabIndex = 1;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.Black;
            this.AboutButton.Image = global::Army_Management_System.Properties.Resources.icons8_about_48;
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.Location = new System.Drawing.Point(0, 228);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(150, 60);
            this.AboutButton.TabIndex = 3;
            this.AboutButton.Text = "ABOUT";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.Transparent;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.ForeColor = System.Drawing.Color.Black;
            this.HelpButton.Image = global::Army_Management_System.Properties.Resources.help2;
            this.HelpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpButton.Location = new System.Drawing.Point(0, 171);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(150, 60);
            this.HelpButton.TabIndex = 5;
            this.HelpButton.Text = "HELP";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.Black;
            this.SearchButton.Image = global::Army_Management_System.Properties.Resources.search3;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(0, 114);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(150, 60);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.Black;
            this.HomeButton.Image = global::Army_Management_System.Properties.Resources.icons8_home_50__1_;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 57);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(150, 60);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // SlidingPanel_ToggleButton
            // 
            this.SlidingPanel_ToggleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SlidingPanel_ToggleButton.BackColor = System.Drawing.Color.Transparent;
            this.SlidingPanel_ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingPanel_ToggleButton.ForeColor = System.Drawing.Color.Black;
            this.SlidingPanel_ToggleButton.Image = global::Army_Management_System.Properties.Resources.right;
            this.SlidingPanel_ToggleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlidingPanel_ToggleButton.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel_ToggleButton.Name = "SlidingPanel_ToggleButton";
            this.SlidingPanel_ToggleButton.Size = new System.Drawing.Size(150, 60);
            this.SlidingPanel_ToggleButton.TabIndex = 2;
            this.SlidingPanel_ToggleButton.UseVisualStyleBackColor = false;
            this.SlidingPanel_ToggleButton.Click += new System.EventHandler(this.SlidingPanel_ToggleButton_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(814, 546);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SlidingPanel);
            this.Controls.Add(this.TitleBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.TitleBar.ResumeLayout(false);
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button LogOffButton;
        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button SlidingPanel_ToggleButton;
        private System.Windows.Forms.Timer SlidingPanel_Timer;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Panel ContentPanel;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Army_Management_System
{
    public partial class AppBody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AppBody()
        {
            InitializeComponent();
            isSlidingPanelExpanded = true;
            expandSlidingPanelGUI();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
    {
        ReleaseCapture();
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
    }
        }

        public void expandSlidingPanelGUI()
        {
            //gui for expanding
            HomeButton.Text = "HOME";
            SearchButton.Text = "SEARCH";
            HelpButton.Text = "HELP";
            AboutButton.Text = "ABOUT";
            SlidingPanel_ToggleButton.Image = Properties.Resources.left;
            HomeButton.Image = null;
            SearchButton.Image = null;
            HelpButton.Image = null;
            AboutButton.Image = null;
        }
        public void retractSlidingPanelGUI()
        {
            //gui for expanding
            HomeButton.Text = "";
            SearchButton.Text = "";
            HelpButton.Text = "";
            AboutButton.Text = "";
            SlidingPanel_ToggleButton.Image = Properties.Resources.right;
            HomeButton.Image = Properties.Resources.icons8_home_50__1_;
            SearchButton.Image = Properties.Resources.search3;
            HelpButton.Image = Properties.Resources.help2;
            AboutButton.Image = Properties.Resources.icons8_about_48;
        }
        //Sliding panel code starts here
        bool isSlidingPanelExpanded; 
        const int MaxSliderWidth = 150;
        const int MinSliderWidth = 80;

        private void SlidingPanel_ToggleButton_Click(object sender, EventArgs e)
        {
            if(isSlidingPanelExpanded)
            {
                //retractSlidingPanelGUI();
            }
            SlidingPanel_Timer.Start(); 
        }

        private void SlidingPanel_Timer_Tick(object sender, EventArgs e)
        {
            
             if(isSlidingPanelExpanded)
            {
                //retract Panel
                 SlidingPanel.Width -= 30; 
                 if(SlidingPanel.Width <= MinSliderWidth)
                 {
                     isSlidingPanelExpanded = false;
                     SlidingPanel_Timer.Stop();
                     retractSlidingPanelGUI();
                     this.Refresh();
                 } 
            }
             else
             {
                 //Expand the sliding panel
                 SlidingPanel.Width += 30;
                 if(SlidingPanel.Width >= MaxSliderWidth)
                 {
                     //stop expanding
                     isSlidingPanelExpanded = true;
                     SlidingPanel_Timer.Stop();
                     expandSlidingPanelGUI();
                     this.Refresh();
                 }
             }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Home_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Home_UserControl.Instance);
                Home_UserControl.Instance.Dock = DockStyle.Fill;
                Home_UserControl.Instance.BringToFront();
            }
            else
            {
                Home_UserControl.Instance.BringToFront();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            
            if (!ContentPanel.Controls.Contains(About_UserControl.Instance))
            {
                ContentPanel.Controls.Add(About_UserControl.Instance);
                About_UserControl.Instance.Dock = DockStyle.Fill;
                About_UserControl.Instance.BringToFront();
            }
            else
            {
                About_UserControl.Instance.BringToFront();
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Help_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Help_UserControl.Instance);
                Help_UserControl.Instance.Dock = DockStyle.Fill;
                Help_UserControl.Instance.BringToFront();
            }
            else
            {
                Help_UserControl.Instance.BringToFront();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Search_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Search_UserControl.Instance);
                Search_UserControl.Instance.Dock = DockStyle.Fill;
                Search_UserControl.Instance.BringToFront();
            }
            else
            {
                Search_UserControl.Instance.BringToFront();
            }
        }
        }
    }


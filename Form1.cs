using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Army_Management_System
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\shushanto\documents\visual studio 2010\Projects\Army Management System\Army Management System\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private String getUsername()
        {
            //fetch username from database
            con.Open();
            String temp = null;
            String query = "SELECT Username FROM systemTable where Username = '" + textBox1.Text.Trim() + "'";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            try
            {
                temp = dr[0].ToString();
            }
            catch (InvalidOperationException)
            {
                label3.Show();
            }
            
            con.Close();
            return temp;
        }

        private String getPass()
        {
            //fetch password from database
            con.Open();
            String temp = null;
            String query = "SELECT Password FROM systemTable where Password = '" + textBox2.Text.Trim() + "'";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            try
            {
             temp = dr[0].ToString();
            }
            catch (InvalidOperationException)
            {
                label3.Show();
            }
            con.Close();
            return temp;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                String Uname = getUsername(), Upass = getPass(), name, pass;
                name = textBox1.Text;
              
                pass = textBox2.Text.Trim();
           
                if (name.Equals(Uname) && pass.Equals(Upass))
                {
                    label3.Hide();
                    
                    AppBody obj = new AppBody();
                    this.Hide();
                    obj.Show();
                }
                else
                {
                    //dont login
                    label3.Show();
                }
        

            }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

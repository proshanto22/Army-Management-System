using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Army_Management_System
{
    public partial class Help_UserControl : UserControl
    {
        private static Help_UserControl _instance;

        public static Help_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Help_UserControl();
                }
                return _instance;
            }
        }
        public Help_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\shushanto\documents\visual studio 2010\Projects\Army Management System\Army Management System\Database.mdf;Integrated Security=True;User Instance=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("select * from ASCTable;", con);


                SqlDataAdapter DL = new SqlDataAdapter(cmd);
                DataSet DK = new DataSet();
                DL.Fill(DK);


                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" <<<<INVALID SQL OPERATION>>>>: \n" + ex);
                }
                con.Close();

                dataGridView1.DataSource = DK.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Regiment", con);
                

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" <<<<INVALID SQL OPERATION>>>>: \n" + ex);
                }
                con.Close();

                dataGridView1.DataSource = DS.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                SqlCommand cmd = new SqlCommand("select * from ITEMS;", con);


                SqlDataAdapter DL = new SqlDataAdapter(cmd);
                DataSet DK = new DataSet();
                DL.Fill(DK);


                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" <<<<INVALID SQL OPERATION>>>>: \n" + ex);
                }
                con.Close();

                dataGridView1.DataSource = DK.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


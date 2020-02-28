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
    public partial class Search_UserControl : UserControl
    {

        private static Search_UserControl _instance;

        public static Search_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Search_UserControl();
                }
                return _instance;
            }
        }

        public Search_UserControl()
        {
            InitializeComponent();
        }
        public string Item_ID;
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\shushanto\documents\visual studio 2010\Projects\Army Management System\Army Management System\Database.mdf;Integrated Security=True;User Instance=True");
        public SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
           try
           {
               SqlCommand cmd = new SqlCommand("Select Item_ID,Reg_ID,Quantity,Req_Date from RequestTable where ASC_UNIT_NO = '" + textBox1.Text + "';", con);
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
                SqlCommand cmd = new SqlCommand("Select Item_ID,ASC_UNIT_NO,Quantity,Req_Date from RequestTable where Reg_ID = '" + textBox1.Text + "';", con);
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

        private void ItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select Reg_ID,ASC_UNIT_NO,Quantity,Req_Date from RequestTable where Item_ID = '" + textBox1.Text + "';", con);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select Item_ID,Reg_ID,ASC_UNIT_NO,Quantity from RequestTable where Req_Date = '" + textBox1.Text + "';", con);
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
    }
}

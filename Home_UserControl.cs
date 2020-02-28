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
    public partial class Home_UserControl : UserControl
    {
        private static Home_UserControl _instance;

        public static Home_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Home_UserControl();
                }
                return _instance;
            }
        }

        public Home_UserControl()
        {
            InitializeComponent();
            
        }




        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\shushanto\documents\visual studio 2010\Projects\Army Management System\Army Management System\Database.mdf;Integrated Security=True;User Instance=True");

        private void button4_Click(object sender, EventArgs e)
        {
            RequestID_TextBox.Text = "";
            Item_TextBox.Text = "";
            ItemType_TextBox.Text = "";
            ASCUno_TextBox.Text = "";
            reg_textBox.Text = "";
            Req_TextBox.Text = "";
        }

        private void Home_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowALLData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

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






        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("ReqeustTableADD_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Item_ID", Item_TextBox.Text);
            
            cmd.Parameters.AddWithValue("@Reg_ID", reg_textBox.Text);
            cmd.Parameters.AddWithValue("@ASC_UNIT_NO", ASCUno_TextBox.Text);
            cmd.Parameters.AddWithValue("@Quantity", Quantity_TextBox.Text);

            cmd.Parameters.AddWithValue("@Req_Date", Req_TextBox.Text);
            
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
            refresh_DataGridView();
        }


        private void textBoxdsad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Delete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Item_ID", Item_TextBox.Text);

                cmd.Parameters.AddWithValue("@Reg_ID", reg_textBox.Text);
                cmd.Parameters.AddWithValue("@ASC_UNIT_NO", ASCUno_TextBox.Text);
                cmd.Parameters.AddWithValue("@Request_ID", RequestID_TextBox.Text);
                cmd.Parameters.AddWithValue("@Req_Date", Req_TextBox.Text);
            
                

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
                refresh_DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void SearchUButton_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand cmd = new SqlCommand("SearchTable_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Request_ID", RequestID_TextBox.Text);
                
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


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Req_TextBox.Text))
            {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update_Quantity", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Quantity", Quantity_TextBox.Text);
            cmd.Parameters.AddWithValue("@Request_ID", RequestID_TextBox.Text);

            
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" <<<<INVALID SQL OPERATION>>>>: \n" + ex);
            }
            con.Close();
            }
            if(string.IsNullOrEmpty(Quantity_TextBox.Text))
            {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("StoredProcedure2", con);
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.AddWithValue("@Req_Date", Req_TextBox.Text);
            cmd1.Parameters.AddWithValue("@Request_ID", RequestID_TextBox.Text);
            try
            {
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" <<<<INVALID SQL OPERATION>>>>: \n" + ex);
            }
            con.Close();
            }
            refresh_DataGridView();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        //Sqlconnection
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R66JUEU\\SQLEXPRESS;Initial Catalog=PCA153;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "insert into s_login(stu_name,stu_pass) values(@u,@p)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", textBox1.Text);
                cmd.Parameters.AddWithValue("@p", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully");
                con.Close();
            }
            catch(Exception ex)
            {
                Console.Write("Connection error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select count(*) from s_login where stu_name=@u and stu_pass=@p";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", textBox1.Text);
                cmd.Parameters.AddWithValue("@p", textBox2.Text);
                int count =(int)cmd.ExecuteScalar();
                if(count>0)
                {
                    MessageBox.Show("user Login successful");
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("connection error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from s_login",con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("connection lost");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

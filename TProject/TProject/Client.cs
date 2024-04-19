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

namespace TProject
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your balance is " + Program.bal);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.cl.Hide();
            Program.si.Show();
            dataGridView1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.cl.Hide();
            Program.se.Show();
            dataGridView1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.cl.Hide();
            Program.wd.Show();
            dataGridView1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.cl.Hide();
            Program.dp.Show();
            dataGridView1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlConnection con = new SqlConnection(Program.conistring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select * from transactiontable where username1 = @username or username2 = @username", con);
                cmd.Parameters.AddWithValue("@username", Program.usern);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.cl.Hide();
            Program.up.Show();
            dataGridView1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlConnection con = new SqlConnection(Program.conistring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select id_client,fname, dateOfBirth, gender, telephone, house, street, neighbourhood, city, country, zipcode, mobile, nationality, social_status, spouceName, birthPlace, clienttable.username, email, password from clienttable, accounts where clienttable.username = accounts.username and accounts.username = @username;", con);
                cmd.Parameters.AddWithValue("username", Program.usern);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Program.cl.Hide();
            Program.iu.Show();
            dataGridView1.Visible = false;
        }
    }
}

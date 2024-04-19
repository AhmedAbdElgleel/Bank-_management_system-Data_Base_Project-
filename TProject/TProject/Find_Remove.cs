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
    public partial class Find_Remove : Form
    {
        public Find_Remove()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlConnection con = new SqlConnection(Program.conistring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select id_client,fname, dateOfBirth, gender, telephone, house, street, neighbourhood, city, country, zipcode, mobile, nationality, social_status, spouceName, birthPlace, clienttable.username, email, password from clienttable, accounts where clienttable.username = accounts.username and accounts.username = @username", con);
                cmd.Parameters.AddWithValue("@username", Program.usern);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.conistring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("delete balancetable where username=@username", con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
            }
            SqlConnection con2 = new SqlConnection(Program.conistring);
            con2.Open();
            if (con2.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd2 = new SqlCommand("delete transactiontable where username1=@username or username2 = @username", con2);
                cmd2.Parameters.AddWithValue("@username", textBox1.Text.ToString());
                cmd2.ExecuteNonQuery();
                con2.Close();
            }
            SqlConnection con3 = new SqlConnection(Program.conistring);
            con3.Open();
            if (con3.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd3 = new SqlCommand("delete clienttable where username=@username", con3);
                cmd3.Parameters.AddWithValue("@username", textBox1.Text.ToString());
                cmd3.ExecuteNonQuery();
                con3.Close();
            }
            SqlConnection con4 = new SqlConnection(Program.conistring);
            con4.Open();
            if (con4.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd4 = new SqlCommand("delete accounts where username=@username", con4);
                cmd4.Parameters.AddWithValue("@username", textBox1.Text.ToString());
                cmd4.ExecuteNonQuery();
                con4.Close();
            }
            MessageBox.Show("Client removed successfuly");
            dataGridView1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.fr.Hide();
            Program.qc.Show();
            dataGridView1.Visible = false;
        }
    }
}

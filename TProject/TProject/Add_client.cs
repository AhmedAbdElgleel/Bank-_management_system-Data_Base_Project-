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
    public partial class Add_client : Form
    {
        public Add_client()
        {
            InitializeComponent();
        }

        private void Add_client_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.conistring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("insert into accounts (username, password, accountType) values('" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "',2)", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            SqlConnection con2 = new SqlConnection(Program.conistring);
            con2.Open();
            if (con2.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd2 = new SqlCommand("insert into clienttable (username, fname, gender, telephone, house, street, neighbourhood, city, country, zipcode, mobile, nationality, social_status, spouceName) values('" + textBox1.Text + "', '" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','"+ textBox6.Text.ToString() +"','"+ textBox7.Text.ToString()+"','"+ textBox8.Text.ToString()+"','"+ textBox9.Text.ToString()+"','"+ textBox10.Text.ToString() + "','"+ textBox11.Text.ToString()+"','"+ textBox12.Text.ToString()+"','"+ textBox13.Text.ToString()+"','"+ textBox14.Text.ToString() +"','"+ textBox15.Text.ToString() +"')", con2);
                cmd2.ExecuteNonQuery();
                con2.Close();
                MessageBox.Show("done");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.ac.Hide();
            Program.qc.Show();
        }
    }
}

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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.em.Hide();
            Program.si.Show();
            Program.em.button6.Visible = false;
            button4.Visible = true;
            button6.Visible = false;
            button7.Visible = false;
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.qc.Show();
            Program.em.Hide();
            dataGridView1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.qe.Show();
            Program.em.Hide();
            dataGridView1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Program.iu.Show();
            Program.em.Hide();
            dataGridView1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlConnection con = new SqlConnection(Program.conistring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select issues.username, issue_details from issues, accounts where accountType = 2", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.up.Show();
            Program.em.Hide();
            dataGridView1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlConnection con = new SqlConnection(Program.conistring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select issues.username, issue_details from issues, accounts where accountType = 1", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}

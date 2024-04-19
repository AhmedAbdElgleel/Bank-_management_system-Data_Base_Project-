using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TProject
{
    public partial class SIGNIN : Form
    {
        public SIGNIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.ToString();
            string ps = textBox2.Text.ToString();
            SqlConnection con = new SqlConnection(Program.conistring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd2 = new SqlCommand("select * from accounts, employees, manager where (accounts.username=employees.username and accounts.username=@username) and (manager.id_emp=employees.id_employees)", con);
                cmd2.Parameters.AddWithValue("username", str);
                SqlDataReader rdr2 = cmd2.ExecuteReader();
                if (rdr2.Read())
                {
                    Program.usern = rdr2["username"].ToString();
                    Program.rps = rdr2["password"].ToString();
                    Program.acctype = "3";
                    Program.id_emp = rdr2["id_emp"].ToString();
                    if (Program.rps == ps) {
                        Program.em.Show();
                        Program.si.Hide();
                        Program.em.button6.Visible = true;
                        Program.em.button7.Visible = true;
                        Program.em.button4.Visible = false;
                        Program.em.button7.Left = 281;
                        Program.em.button7.Top = 158;
                    }
                }
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from accounts,balancetable where accounts.username = @username and accounts.username = balancetable.username", con);
                cmd.Parameters.AddWithValue("username", str);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Program.usern = rdr["username"].ToString();
                    Program.rps = rdr["password"].ToString();
                    Program.acctype = rdr["accountType"].ToString();
                    Program.bal = rdr["balance"].ToString();
                    if (Program.rps == ps && Program.acctype == "1")
                    {
                        Program.em.Show();
                        Program.si.Hide();
                    }
                    else if (Program.rps == ps && Program.acctype == "2")
                    {
                        Program.cl.Show();
                        Program.si.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password is wrong.");
                    }
                }
                /*else
                {
                    MessageBox.Show("Username is wrong.");
                }*/
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.si.Close();
        }
    }
}
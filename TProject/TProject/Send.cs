using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TProject
{
    public partial class Send : Form
    {
        public Send()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.se.Hide();
            Program.cl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string amount = textBox2.Text.ToString();
            float x = float.Parse(Program.bal, CultureInfo.InvariantCulture.NumberFormat);
            float y = float.Parse(amount, CultureInfo.InvariantCulture.NumberFormat);
            int x1 = (int)x;
            if (x < y)
            {
                MessageBox.Show("Insufficient amount.");
            }
            else
            {
                if (Program.usern == textBox1.Text.ToString())
                {
                    MessageBox.Show("you can't send money to yourself.");
                }
                else
                {
                    SqlConnection con = new SqlConnection(Program.conistring);
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("update balancetable set balance = @balance1 - @balance2 where username = @username", con);
                        cmd.Parameters.AddWithValue("@balance1", x);
                        cmd.Parameters.AddWithValue("@balance2", y);
                        cmd.Parameters.AddWithValue("@username", Program.usern);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("insert into transactiontable values('" + Program.usern + "', '" + textBox1.Text.ToString() + "','" + y + "','no date')", con);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("done");
                    }
                }
            }
        }
    }
}

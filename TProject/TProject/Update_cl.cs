using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TProject
{
    public partial class Update_cl : Form
    {
        public Update_cl()
        {
            InitializeComponent();
        }

        private void Update_cl_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.qc.Show();
            Program.uc.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

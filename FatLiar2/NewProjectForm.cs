using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FatLiar2
{
    public partial class NewProjectForm : Form
    {
        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.WorkersConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Projects (name, is_state_funded) values (@pname, @gov);", conn);
                cmd.Parameters.AddWithValue("@pname", textBox1.Text);
                cmd.Parameters.AddWithValue("@gov", checkBox1.Checked);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

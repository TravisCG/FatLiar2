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

namespace FatLiar2
{
    public partial class NewPersonForm : Form
    {
        public NewPersonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.WorkersConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Persons (name) values (@pname);", conn);
                cmd.Parameters.AddWithValue("@pname", textBox1.Text);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

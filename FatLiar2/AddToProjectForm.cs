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
    public partial class AddToProjectForm : Form
    {
        public AddToProjectForm()
        {
            InitializeComponent();
        }

        private void AddToProjectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workersDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.workersDataSet.Projects);
            // TODO: This line of code loads data into the 'workersDataSet.Persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter.Fill(this.workersDataSet.Persons);

        }

        private void AddToProject_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.WorkersConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Person2Project (person_id, project_id, money) values (@person, @project, @money)", conn);
                cmd.Parameters.AddWithValue("@person", PersonCombo.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@project", ProjectCombo.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@money", float.Parse(MoneyTextBox.Text));
                cmd.ExecuteNonQuery();
            }
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newperson = new NewPersonForm();
            newperson.ShowDialog();
            this.personsTableAdapter.Fill(this.workersDataSet.Persons);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workersDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.workersDataSet.Projects);
            this.personsTableAdapter.Fill(this.workersDataSet.Persons);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form newproject = new NewProjectForm();
            newproject.ShowDialog();
            this.projectsTableAdapter.Fill(this.workersDataSet.Projects);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateListBox.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.WorkersConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select Persons.name from Holidays left join Persons on Holidays.person_id = Persons.person_id where date = @date;", conn);
                cmd.Parameters.AddWithValue("@date", e.Start);
                SqlDataReader results = cmd.ExecuteReader();
                while (results.Read())
                {
                    string dayis = results.GetString(0).TrimEnd() + ": holiday";
                    DateListBox.Items.Add(dayis);
           
                }
                results.Close();
                cmd = new SqlCommand("select * from CommonDates where date = @date;", conn);
                cmd.Parameters.AddWithValue("@date", e.Start);
                results = cmd.ExecuteReader();
                while (results.Read())
                {
                    string dayis = results.GetDateTime(1).ToShortDateString();
                    if (results.GetSqlBoolean(2))
                    {
                        dayis += " is holiday for everyone";
                    }
                    if (results.GetSqlBoolean(3))
                    {
                        dayis += " extra workday";
                    }
                    DateListBox.Items.Add(dayis);
                }
            }
        }

        private void addCommonDate(DateTime date, bool is_holiday)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.WorkersConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into CommonDates (date, is_holiday, is_extra) values (@date, @holiday, @extra)", conn);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@holiday", is_holiday);
                cmd.Parameters.AddWithValue("@extra", !is_holiday);
                cmd.ExecuteNonQuery();
            }
        }

        private void addExtraWorkdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCommonDate(monthCalendar1.SelectionStart, false);
        }

        private void festivalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCommonDate(monthCalendar1.SelectionStart, true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.WorkersConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Holidays (person_id, date) values (@person, @date)", conn);
                cmd.Parameters.AddWithValue("@person", PersonComboBox.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@date", monthCalendar1.SelectionStart);
                cmd.ExecuteNonQuery();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form addp2p = new AddToProjectForm();
            addp2p.ShowDialog();
        }

        private void GeneratePersonRiport_Click(object sender, EventArgs e)
        {
            int person_id      = PersonComboBox2.SelectedIndex + 1;
            DateTime startdate = PersonRiportStartDate.Value;
            DateTime enddate   = PersonRiportEndDate.Value;
            Form personriport  = new PersonRiportForm(person_id, startdate, enddate);
            personriport.Show();
        }

        private void GenerateProjectReport_Click(object sender, EventArgs e)
        {
            int project_id     = ProjectComboBox.SelectedIndex + 1;
            DateTime startdate = ProjectRiportStartDate.Value;
            DateTime enddate   = ProjectRiportEndDate.Value;
        }
    }
}

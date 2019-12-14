using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatLiar2
{
    public partial class PersonRiportForm : Form
    {
        private int person_id;
        private DateTime startdate;
        private DateTime enddate;

        public PersonRiportForm(int person_id, DateTime startdate, DateTime enddate)
        {
            InitializeComponent();
            this.person_id = person_id;
            this.startdate = startdate;
            this.enddate = enddate;
        }

        private void PersonRiportForm_Load(object sender, EventArgs e)
        {
        }
    }
}

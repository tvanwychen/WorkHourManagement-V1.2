using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkHourManagement_V1._2
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtbPayPeriodsDataSet.tblPayPeriods' table. You can move, or remove it, as needed.
            this.tblPayPeriodsTableAdapter.Fill(this.dtbPayPeriodsDataSet.tblPayPeriods);
            lblTDay.Text = DateTime.Now.ToString("MM-dd-yyyy");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtBxLaborTime.Clear();
            txtBxRO.Clear();
        }

        private void cmbBxPayPeriods_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}

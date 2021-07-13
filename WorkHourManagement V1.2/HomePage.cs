using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

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
            lblTDay.Text = DateTime.Now.ToString("MM-dd-yyyy");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.Date = DateTime.Now;
            //table.Date = DateTime.Now.GetDateTimeFormats();
            table.RO = txtBxRO.Text;
            table.LaborHours = txtBxLaborTime.Text;

            Insert(table);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtBxLaborTime.Clear();
            txtBxRO.Clear();
        }

        private void cmbBxPayPeriods_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private List<Table> Load(DateTime startdate, DateTime enddate)
        {
            using (dtbPayPeriodsEntities dc = new dtbPayPeriodsEntities())
            {
                List<Table> table = new List<Table>();

                dc.tblPayPeriods.ToList().ForEach(x => table.Add(
                    new Table { Id = x.Id, Date = x.Date, LaborHours = x.LaborHours, RO = x.RO }));

                //dc.tblPayPeriods.ToList().ForEach(x => table.Where(y => y.Date >= startdate && y.Date <= enddate).Add(
                //    new Table { Id = x.Id, Date = x.Date, LaborHours = x.LaborHours, RO = x.RO }));

                return table;
            }
        }

        private void Insert(Table table)
        {
            try
            {
                using (dtbPayPeriodsEntities dc = new dtbPayPeriodsEntities())
                {
                    DbContextTransaction transaction = null;

                    tblPayPeriod tblPp = new tblPayPeriod();
                    tblPp.Id = dc.tblPayPeriods.Any() ? dc.tblPayPeriods.Max(x => x.Id) + 1 : 1;
                    tblPp.Date = tblPp.Date;
                    tblPp.LaborHours = table.LaborHours;
                    tblPp.RO = table.RO;

                    table.Id = tblPp.Id;

                    dc.tblPayPeriods.Add(tblPp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Delete(string ro)
        {
            try
            {
                using (dtbPayPeriodsEntities dc = new dtbPayPeriodsEntities())
                {
                    DbContextTransaction transaction = null;

                    tblPayPeriod row = dc.tblPayPeriods.FirstOrDefault(x => x.RO == ro);

                    if (row != null)
                    {
                        dc.tblPayPeriods.Remove(row);
                    }
                    else
                    {
                        throw new Exception("RO not found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace McbitssDevReports.Reports.IndiaReports
{
    public partial class IndiaPayrollReport : DevExpress.XtraReports.UI.XtraReport
    {
        public IndiaPayrollReport()
        {
            InitializeComponent();
        }

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
             //var year = this.GetCurrentColumnValue("year").ToString();
             //   var month = xrLabel6.Text;
             //   xrLabel6.Text = xrLabel6.Text + "  " + year;
           
        }
    }
}

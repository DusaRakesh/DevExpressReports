using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace McbitssDevReports.Reports.SwissReports
{
    public partial class SwissEmpPayslip : DevExpress.XtraReports.UI.XtraReport
    {
        public SwissEmpPayslip()
        {
            InitializeComponent();
        }

        //private void xrLabel18_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    var Emplastname = this.GetCurrentColumnValue("Emplastname").ToString();
        //    var month = xrLabel18.Text;
        //    xrLabel18.Text = xrLabel18.Text + " " + Emplastname;
        //}

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var year = this.GetCurrentColumnValue("SalYear");
            var month = xrLabel6.Text;
            xrLabel6.Text = xrLabel6.Text + "  " + year;
        }

       
    }
}

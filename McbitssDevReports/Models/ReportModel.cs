using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace McbitssDevReports.Models
{
    public class ReportModel
    {
        public class FamilyAllowance
        {
            public int rate { get; set; }
            public int dependants { get; set; }
            public string name { get; set; }
        }

        public class Benefit
        {
            public string id { get; set; }
            public int amount { get; set; }
            public string name { get; set; }
        }

        public class SocialDeduction
        {
            public double employeeTotal { get; set; }
            public int employeeBase { get; set; }
            public double employerTotal { get; set; }
            public int employerBase { get; set; }
            public string id { get; set; }
            public string code { get; set; }
            public bool mandatory { get; set; }
            public string employerCont { get; set; }
            public string empCont { get; set; }
            public string name { get; set; }
        }

        public class Allowance
        {
            public string id { get; set; }
            public int totalAmount { get; set; }
            public int rate { get; set; }
            public string name { get; set; }
        }

        public class OtherDeduction
        {
            public string id { get; set; }
            public double amount { get; set; }
            public string name { get; set; }
        }

        public class Leaf
        {
            public string id { get; set; }
            public string eligible { get; set; }
            public string consumed { get; set; }
            public string name { get; set; }
        }

        public class Payroll
        {
            public FamilyAllowance familyAllowance { get; set; }
            public string status { get; set; }
            public List<Benefit> benefits { get; set; }
            public List<SocialDeduction> socialDeductions { get; set; }
            public List<Allowance> allowance { get; set; }
            public List<OtherDeduction> otherDeductions { get; set; }
            public List<Leaf> leaves { get; set; }
            public string id { get; set; }
            public object weeklyHours { get; set; }
            public int monthlySalary { get; set; }
            public string salarymonth { get; set; }
            public string salaryYear { get; set; }
            public int incomeTaxRate { get; set; }
            public double monthlyGrossSalary { get; set; }
            public double MonthlyTax { get; set; }
            public int? totalQST { get; set; }
            public int employerCost { get; set; }
            public double empTotal { get; set; }
            public int totalAllowance { get; set; }
            public double totaldeductions { get; set; }
            public double empSocialDeductions { get; set; }
        }

        public class RootObject
        {
            public string id { get; set; }
            public string employee { get; set; }
            public DateTime updatedAt { get; set; }
            public string company { get; set; }
            public string branch { get; set; }
            public List<Payroll> payroll { get; set; }
            public int v { get; set; }
            public DateTime createdAt { get; set; }
        }

        //public class LeavesAudit
        //{
        //    public string operation { get; set; }
        //    public DateTime insertedDate { get; set; }
        //    public string insertedBy { get; set; }
        //    public DateTime yearEndDate { get; set; }
        //    public DateTime yearStartDate { get; set; }
        //    public int numberOfDays { get; set; }
        //    public string timeOffType { get; set; }
        //    public string role { get; set; }
        //    public string country { get; set; }
        //    public string id { get; set; }
        //    public string status { get; set; }
        //}

        //public class RootObject
        //{
        //    public string id { get; set; }
        //    public int v { get; set; }
        //    public List<LeavesAudit> leavesAudit { get; set; }
        //}
    }
}
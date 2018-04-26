using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace McbitssDevReports.Models
{
    public class IndiaDataModel
    {
        public class Benefit
        {
            public string id { get; set; }
            public string markTaxDeductionAtSource { get; set; }
            public string socialContributionRelevant { get; set; }
            public string earningIndex { get; set; }
            public string code { get; set; }
            public int amount { get; set; }
            public string name { get; set; }
        }

        public class OtherDeduction
        {
            public double amount { get; set; }
            public string name { get; set; }
        }

        public class SocialDeduction
        {
            public int amount { get; set; }
            public int employeeTotal { get; set; }
            public int employeeBase { get; set; }
            public int employerTotal { get; set; }
            public int employerBase { get; set; }
            public string id { get; set; }
            public string code { get; set; }
            public bool mandatory { get; set; }
            public int employerCont { get; set; }
            public int empCont { get; set; }
            public string name { get; set; }
        }

        public class Leaf
        {
            public int eligible { get; set; }
            public int consumed { get; set; }
            public string name { get; set; }
        }

        public class FamilyAllowance
        {
            public int rate { get; set; }
            public int dependants { get; set; }
            public int empBaseAmount { get; set; }
            public string name { get; set; }
        }

        public class Payroll
        {
            public double taxToBePaid { get; set; }
            public int presentDays { get; set; }
            public int noOfWorkingDays { get; set; }
            public object weeklyHours { get; set; }
            public int lopSalaryDedcution { get; set; }
            public int employeeActualWorkingHours { get; set; }
            public int employeeTargetWorkingHours { get; set; }
            public int monthlySalary { get; set; }
            public string employeeId { get; set; }
            public string salarymonth { get; set; }
            public int salaryYear { get; set; }
            public List<Benefit> benefits { get; set; }
            public List<object> allowance { get; set; }
            public int incomeTaxRate { get; set; }
            public int monthlyGrossSalary { get; set; }
            public double MonthlyTax { get; set; }
            public string totalQST { get; set; }
            public int employerCost { get; set; }
            public double empTotal { get; set; }
            public int totalAllowance { get; set; }
            public double totaldeductions { get; set; }
            public int employerSocialDeductions { get; set; }
            public int empSocialDeductions { get; set; }
            public List<OtherDeduction> otherDeductions { get; set; }
            public List<SocialDeduction> socialDeductions { get; set; }
            public List<Leaf> leaves { get; set; }
            public string status { get; set; }
            public FamilyAllowance familyAllowance { get; set; }
            public int fte { get; set; }
            public int age { get; set; }
        }

        public class RootObjectIndia
        {
            public string id { get; set; }
            public int v { get; set; }
            public string customer { get; set; }
            public string company { get; set; }
            public string employee { get; set; }
            public string location { get; set; }
            public List<Payroll> payroll { get; set; }
        }

       

        //public class RootObjectIndia
        //{
        //    public string id { get; set; }
        //    public int v { get; set; }
        //    public string customer { get; set; }
        //    public string company { get; set; }
        //    public string employee { get; set; }
        //    public string location { get; set; }
        //    public List<Payroll> payroll { get; set; }
        //}
    }
}
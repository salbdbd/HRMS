using System.Collections.Generic;

namespace Hrms.Models
{
   public class FinalSettlementModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public decimal DueSalary { get;set; }
      public decimal Bonus { get;set; }
      public decimal NoticeEmp { get;set; }
      public decimal EL { get;set; }
      public decimal Gratuty { get;set; }
      public decimal Death { get;set; }
      public decimal Exgratia { get;set; }
      public decimal OverTime { get;set; }
      public decimal NoticePayCompany { get;set; }
      public decimal ExcessSalary { get;set; }
      public decimal EPS { get;set; }
      public decimal Mobile { get;set; }
      public decimal StaffOther { get;set; }
      public decimal WPPF { get;set; }
      public decimal PFOwn { get;set; }
      public decimal PFCompany { get;set; }
      public decimal PFLoan { get;set; }
      public decimal PFLInterest { get;set; }
      public decimal Tax { get;set; }
      public decimal DriverAllowance { get;set; }
      public DateTime LastWorkingDate { get;set; }
      public int CompanyID { get;set; }
      public int PeriodID { get;set; }
      public decimal PerformanceBonus { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class SubsistenceAllowanceModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public decimal Amount { get;set; }
      public decimal SubAmount { get;set; }
      public int Action { get;set; }
      public string Description { get;set; }
      public int SalaryHead { get;set; }
      public int PaydDays { get;set; }
      public int DayofMonths { get;set; }
      public int SalaryPeriodID { get;set; }
      public int PaidPeriodID { get;set; }
      public DateTime PaymentDate { get;set; }
      public int PaymentType { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
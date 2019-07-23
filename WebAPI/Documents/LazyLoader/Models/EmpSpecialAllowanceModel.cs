using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpSpecialAllowanceModel
   {
      public int ID { get;set; }
      public int EmpID { get;set; }
      public string EmpCode { get;set; }
      public int SalaryHeadID { get;set; }
      public decimal Amount { get;set; }
      public int SalaryPeriodID { get;set; }
      public int CompanyID { get;set; }
   }
}
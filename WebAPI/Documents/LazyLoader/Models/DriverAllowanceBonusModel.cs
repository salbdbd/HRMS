using System.Collections.Generic;

namespace Hrms.Models
{
   public class DriverAllowanceBonusModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int SalaryHeadID { get;set; }
      public decimal Amount { get;set; }
      public int PeriodID { get;set; }
      public int BonusID { get;set; }
      public int CompanyID { get;set; }
      public DateTime PDate { get;set; }
      public int UserID { get;set; }
   }
}
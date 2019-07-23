using System.Collections.Generic;

namespace Hrms.Models
{
   public class ProcessExcessSalaryModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int SalaryID { get;set; }
      public decimal Amount { get;set; }
      public int PeriodID { get;set; }
      public string Note { get;set; }
      public int CompanyID { get;set; }
   }
}
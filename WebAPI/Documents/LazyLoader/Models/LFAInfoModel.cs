using System.Collections.Generic;

namespace Hrms.Models
{
   public class LFAInfoModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int PeriodID { get;set; }
      public decimal Amount { get;set; }
      public int SalaryYearID { get;set; }
      public int TaxYearID { get;set; }
      public string CreatedDate { get;set; }
      public int CompanyID { get;set; }
   }
}
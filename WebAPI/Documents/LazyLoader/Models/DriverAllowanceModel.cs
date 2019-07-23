using System.Collections.Generic;

namespace Hrms.Models
{
   public class DriverAllowanceModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int SalaryHeadID { get;set; }
      public int TaxYearID { get;set; }
      public decimal Amount { get;set; }
      public int SalaryTypeID { get;set; }
      public int PeriodID { get;set; }
      public string PeriodName { get;set; }
      public int CompanyID { get;set; }
   }
}
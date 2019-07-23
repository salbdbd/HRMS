using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class WPPFViewModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int PeriodID { get;set; }
      public int SalaryHeadID { get;set; }
      public decimal Amount { get;set; }
      public decimal OTPP { get;set; }
      public int BonusType { get;set; }
      public string Date { get;set; }
      public int CompanyID { get;set; }
      public int TaxYearID { get;set; }
   }
}
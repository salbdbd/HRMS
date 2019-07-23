using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class View_sabeViewModel
   {
      public int PeriodID { get;set; }
      public int SalaryHeadID { get;set; }
      public decimal Amount { get;set; }
      public decimal OTPP { get;set; }
      public int BonusType { get;set; }
      public string Date { get;set; }
      public int CompanyID { get;set; }
      public string EmpCode { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class ImportPFModel
   {
      public int ID { get;set; }
      public string Empcode { get;set; }
      public int SalaryHead { get;set; }
      public decimal Amount { get;set; }
      public int PeriodID { get;set; }
      public int BonusType { get;set; }
      public int CompanyID { get;set; }
      public string PeriodName { get;set; }
   }
}
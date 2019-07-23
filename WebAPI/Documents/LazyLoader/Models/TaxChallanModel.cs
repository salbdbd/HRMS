using System.Collections.Generic;

namespace Hrms.Models
{
   public class TaxChallanModel
   {
      public int ID { get;set; }
      public int TaxYearID { get;set; }
      public string TaxChallanNo { get;set; }
      public string ChallanDate { get;set; }
      public int SalaryPeriodID { get;set; }
      public string CreatedDate { get;set; }
      public int CompanyID { get;set; }
   }
}
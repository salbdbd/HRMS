using System.Collections.Generic;

namespace Hrms.Models
{
   public class AdditionalTaxInfoModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int SalaryHeadID { get;set; }
      public decimal ExemptAmount { get;set; }
      public decimal ExemptPercent { get;set; }
      public string ExemptRule { get;set; }
      public int TaxYearID { get;set; }
      public int CompanyID { get;set; }
   }
}
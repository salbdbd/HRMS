using System.Collections.Generic;

namespace Hrms.Models
{
   public class IncomeTaxSetupModel
   {
      public int ID { get;set; }
      public int SalaryHeadID { get;set; }
      public int TaxYearID { get;set; }
      public string TaxYearName { get;set; }
      public string Exemption { get;set; }
      public decimal ExempAmount { get;set; }
      public decimal ExempPercent { get;set; }
      public int ExempPercentOfID { get;set; }
      public decimal ExempMaxAmount { get;set; }
      public string ExempRule { get;set; }
      public string CreatedDate { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class TaxMinimumTaxModel
   {
      public int ID { get;set; }
      public int TaxYearID { get;set; }
      public decimal MinimumTax { get;set; }
      public decimal InvestRate { get;set; }
      public decimal InvestMaxamount { get;set; }
      public decimal RebateRate { get;set; }
      public decimal CarPersent { get;set; }
      public decimal HousePersent { get;set; }
      public DateTime SDate { get;set; }
      public string Note { get;set; }
      public int CompanyID { get;set; }
   }
}
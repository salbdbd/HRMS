using System.Collections.Generic;

namespace Hrms.Models
{
   public class SlabIncomeTaxModel
   {
      public int ID { get;set; }
      public int TaxYearID { get;set; }
      public int SlabTypeID { get;set; }
      public decimal Amount { get;set; }
      public decimal TaxRate { get;set; }
      public string SlabText { get;set; }
      public decimal TaxAmount { get;set; }
      public int CompanyID { get;set; }
      public int SortOrder { get;set; }
      public int SlabOrder { get;set; }
   }
}
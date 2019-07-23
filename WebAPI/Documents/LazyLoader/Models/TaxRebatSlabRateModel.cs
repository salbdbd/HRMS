using System.Collections.Generic;

namespace Hrms.Models
{
   public class TaxRebatSlabRateModel
   {
      public int ID { get;set; }
      public int RebatSlabID { get;set; }
      public decimal Amount { get;set; }
      public decimal Rate { get;set; }
      public int TaxYearID { get;set; }
   }
}
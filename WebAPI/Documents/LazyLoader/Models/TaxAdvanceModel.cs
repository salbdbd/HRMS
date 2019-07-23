using System.Collections.Generic;

namespace Hrms.Models
{
   public class TaxAdvanceModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int TaxYear { get;set; }
      public decimal Amount { get;set; }
      public string Note { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
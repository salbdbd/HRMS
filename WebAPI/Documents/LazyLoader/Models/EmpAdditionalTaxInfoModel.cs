using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpAdditionalTaxInfoModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int TaxItemID { get;set; }
      public int CompanyID { get;set; }
   }
}
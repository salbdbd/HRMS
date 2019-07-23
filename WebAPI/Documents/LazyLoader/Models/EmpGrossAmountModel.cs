using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpGrossAmountModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int StructureID { get;set; }
      public decimal GrossAmount { get;set; }
      public int CompanyID { get;set; }
   }
}
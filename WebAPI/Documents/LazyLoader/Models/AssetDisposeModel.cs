using System.Collections.Generic;

namespace Hrms.Models
{
   public class AssetDisposeModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int PropertyID { get;set; }
      public int ModelID { get;set; }
      public DateTime DisposeDate { get;set; }
      public string DisType { get;set; }
      public string Note { get;set; }
      public int CompanyID { get;set; }
   }
}
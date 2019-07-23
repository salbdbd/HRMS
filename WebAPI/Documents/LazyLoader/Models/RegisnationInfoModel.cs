using System.Collections.Generic;

namespace Hrms.Models
{
   public class RegisnationInfoModel
   {
      public int id { get;set; }
      public string EmpCode { get;set; }
      public string ResignType { get;set; }
      public string Type { get;set; }
      public string Status { get;set; }
      public DateTime Date { get;set; }
      public string IsCanBack { get;set; }
      public string Reason { get;set; }
      public int CompanyID { get;set; }
   }
}
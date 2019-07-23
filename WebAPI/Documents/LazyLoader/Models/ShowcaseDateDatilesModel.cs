using System.Collections.Generic;

namespace Hrms.Models
{
   public class ShowcaseDateDatilesModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int Type { get;set; }
      public DateTime ShowcaseDate { get;set; }
      public int Action { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class NoticeLettreModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string Lettre { get;set; }
      public int Type { get;set; }
      public DateTime LDate { get;set; }
      public int CompanyID { get;set; }
      public string Reason { get;set; }
      public DateTime EntryDate { get;set; }
      public int ApproveType { get;set; }
   }
}
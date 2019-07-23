using System.Collections.Generic;

namespace Hrms.Models
{
   public class AttendanceApplicationModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string Reason { get;set; }
      public DateTime AttnDate { get;set; }
      public string InTime { get;set; }
      public string OutTime { get;set; }
      public DateTime EntryDate { get;set; }
      public int ApproveType { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
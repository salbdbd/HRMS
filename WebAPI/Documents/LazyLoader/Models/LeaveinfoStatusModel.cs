using System.Collections.Generic;

namespace Hrms.Models
{
   public class LeaveinfoStatusModel
   {
      public int ID { get;set; }
      public int LeaveID { get;set; }
      public string ReqFrom { get;set; }
      public string ReqTo { get;set; }
      public DateTime StatusDate { get;set; }
      public int Status { get;set; }
      public int COmpanyID { get;set; }
      public string Remarks { get;set; }
   }
}
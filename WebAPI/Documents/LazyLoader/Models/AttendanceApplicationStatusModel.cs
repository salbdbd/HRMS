using System.Collections.Generic;

namespace Hrms.Models
{
   public class AttendanceApplicationStatusModel
   {
      public int ID { get;set; }
      public int AttendanceID { get;set; }
      public string ReqFrom { get;set; }
      public string ReqTo { get;set; }
      public DateTime StatusDate { get;set; }
      public int Status { get;set; }
      public int UserID { get;set; }
      public int COmpanyID { get;set; }
   }
}
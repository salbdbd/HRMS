using System.Collections.Generic;

namespace Hrms.Models
{
   public class LeaveDetailsModel
   {
      public int ID { get;set; }
      public int LeaveID { get;set; }
      public string EmpCode { get;set; }
      public DateTime LeaveDate { get;set; }
   }
}
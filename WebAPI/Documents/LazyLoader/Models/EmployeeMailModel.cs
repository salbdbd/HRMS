using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmployeeMailModel
   {
      public int Id { get;set; }
      public string EmpCod { get;set; }
      public string SendTo { get;set; }
      public DateTime SendTime { get;set; }
      public string Message { get;set; }
      public int ComCod { get;set; }
   }
}
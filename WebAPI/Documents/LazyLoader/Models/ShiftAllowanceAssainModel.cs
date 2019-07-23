using System.Collections.Generic;

namespace Hrms.Models
{
   public class ShiftAllowanceAssainModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int ActiveType { get;set; }
      public int CreateUser { get;set; }
      public DateTime SystemDate { get;set; }
      public int CompanyID { get;set; }
   }
}
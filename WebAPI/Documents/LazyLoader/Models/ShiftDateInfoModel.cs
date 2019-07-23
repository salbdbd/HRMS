using System.Collections.Generic;

namespace Hrms.Models
{
   public class ShiftDateInfoModel
   {
      public int id { get;set; }
      public int shiftid { get;set; }
      public string EmpCode { get;set; }
      public DateTime ShiftDate { get;set; }
   }
}
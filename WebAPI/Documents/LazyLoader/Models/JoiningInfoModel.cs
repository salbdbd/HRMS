using System.Collections.Generic;

namespace Hrms.Models
{
   public class JoiningInfoModel
   {
      public string Department { get;set; }
      public string EmpCode { get;set; }
      public string Designation { get;set; }
      public string Grade { get;set; }
      public DateTime JoiningDate { get;set; }
      public decimal Salary { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class NewSalaryModel
   {
      public string EmpCode { get;set; }
      public float Basic { get;set; }
      public float HR { get;set; }
      public float CON { get;set; }
      public float MED# { get;set; }
      public float Bev# { get;set; }
      public float Incentive { get;set; }
      public string Grade { get;set; }
      public string NewGrade { get;set; }
   }
}
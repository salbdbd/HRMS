using System.Collections.Generic;

namespace Hrms.Models
{
   public class PromotionSheetModel
   {
      public string EmpCode { get;set; }
      public string EmpName { get;set; }
      public string Designation { get;set; }
      public float Basic { get;set; }
      public float HR { get;set; }
      public float CON { get;set; }
      public float MED { get;set; }
      public float Bev { get;set; }
      public float Incentive { get;set; }
      public string Grade { get;set; }
      public string NewGrade { get;set; }
      public string GradeName { get;set; }
      public int PayscaleYear { get;set; }
      public int PayScaleID { get;set; }
      public int NewPayScale { get;set; }
   }
}
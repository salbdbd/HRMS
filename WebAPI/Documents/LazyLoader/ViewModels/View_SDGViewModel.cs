using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class View_SDGViewModel
   {
      public int ID { get;set; }
      public int GradeValue { get;set; }
      public int CompanyID { get;set; }
      public string GradeName { get;set; }
      public string GradeDescription { get;set; }
      public decimal IncrementAmount { get;set; }
      public decimal Basic { get;set; }
      public decimal Hrent { get;set; }
      public decimal DA { get;set; }
      public decimal Others { get;set; }
      public decimal Convance { get;set; }
      public decimal Medicale { get;set; }
      public decimal Beverage { get;set; }
      public decimal Incentive { get;set; }
      public decimal Entertainment { get;set; }
      public string PayscaleYear { get;set; }
      public int TAG { get;set; }
      public int PayscaleID { get;set; }
      public int Expr1 { get;set; }
   }
}
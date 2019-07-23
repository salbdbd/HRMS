using System.Collections.Generic;

namespace Hrms.Models
{
   public class AchievementKPIModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int EmpKpiID { get;set; }
      public string Achievement { get;set; }
      public decimal Score { get;set; }
      public string Comment { get;set; }
      public string ManComment { get;set; }
      public string EmpComment { get;set; }
      public int YearID { get;set; }
      public int QuarterID { get;set; }
      public int CompanyID { get;set; }
      public int UserID { get;set; }
      public DateTime CreateDate { get;set; }
      public DateTime UpdateDate { get;set; }
      public int IsFinal { get;set; }
      public decimal AchievmentPercnt { get;set; }
      public int IsAgreeBoss { get;set; }
   }
}
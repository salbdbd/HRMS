using System.Collections.Generic;

namespace Hrms.Models
{
   public class YTDSetupModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int KpiID { get;set; }
      public string KpiName { get;set; }
      public int KpiType { get;set; }
      public string Target { get;set; }
      public string Achievement { get;set; }
      public decimal AvgWeight { get;set; }
      public decimal WeightYearly { get;set; }
      public decimal AchvPercentage { get;set; }
      public decimal Score { get;set; }
      public int IsAgree { get;set; }
      public int YearID { get;set; }
      public int CompanyID { get;set; }
      public int UserID { get;set; }
      public DateTime CreateDate { get;set; }
      public DateTime UpdateDate { get;set; }
      public int IsBossAgree { get;set; }
      public int IsFinal { get;set; }
      public string EmpComment { get;set; }
      public string BossComment { get;set; }
   }
}
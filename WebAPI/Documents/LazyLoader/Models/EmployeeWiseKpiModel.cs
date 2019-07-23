using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmployeeWiseKpiModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int QuarterId { get;set; }
      public int KPIType { get;set; }
      public int KpiID { get;set; }
      public string Target { get;set; }
      public decimal Weight { get;set; }
      public int CompanyID { get;set; }
      public int UserID { get;set; }
      public DateTime CreateDate { get;set; }
      public DateTime UpdateDate { get;set; }
      public int IsAgree { get;set; }
      public int YearID { get;set; }
      public DateTime AgreeDate { get;set; }
      public string ReportTo { get;set; }
      public int IsBossAgree { get;set; }
      public int IsBossEdit { get;set; }
   }
}
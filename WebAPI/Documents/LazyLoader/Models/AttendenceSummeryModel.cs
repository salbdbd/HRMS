using System.Collections.Generic;

namespace Hrms.Models
{
   public class AttendenceSummeryModel
   {
      public int id { get;set; }
      public string EmpCode { get;set; }
      public int AttendenceDay { get;set; }
      public int LeaveWithPay { get;set; }
      public int LeaveWithoutPay { get;set; }
      public int Holiday { get;set; }
      public int Absent { get;set; }
      public int TotalDay { get;set; }
      public int PeriodID { get;set; }
      public DateTime StartDate { get;set; }
      public DateTime EndDate { get;set; }
      public int CompanyID { get;set; }
      public int UserID { get;set; }
      public string Remarks { get;set; }
   }
}
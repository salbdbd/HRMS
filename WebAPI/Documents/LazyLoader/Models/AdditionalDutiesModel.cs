using System.Collections.Generic;

namespace Hrms.Models
{
   public class AdditionalDutiesModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int PayType { get;set; }
      public int Department { get;set; }
      public int Designation { get;set; }
      public int SchoolorOffice { get;set; }
      public string Responsibilities { get;set; }
      public DateTime NoticeIssuedDate { get;set; }
      public DateTime EffFromDate { get;set; }
      public DateTime EffToDate { get;set; }
      public string Duration { get;set; }
      public decimal Amount { get;set; }
      public string Remark { get;set; }
      public int CompanyID { get;set; }
      public int UserID { get;set; }
   }
}
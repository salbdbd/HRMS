using System.Collections.Generic;

namespace Hrms.Models
{
   public class OTApplyModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string Reason { get;set; }
      public DateTime OTDate { get;set; }
      public string DDMMYY { get;set; }
      public string InTime { get;set; }
      public string OutTime { get;set; }
      public decimal OTHoursApply { get;set; }
      public decimal OTHoursApprove { get;set; }
      public int ApproveByBoss { get;set; }
      public string ApplyToEmpcode { get;set; }
      public int ApproveByHR { get;set; }
      public int ApproveByHRID { get;set; }
      public DateTime EntryDate { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
      public int SendApprove { get;set; }
      public string NightAllowance { get;set; }
      public int OTReason { get;set; }
      public string Note { get;set; }
   }
}
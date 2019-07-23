using System.Collections.Generic;

namespace Hrms.Models
{
   public class EncashLeaveSetupModel
   {
      public int ID { get;set; }
      public int EmpGrade { get;set; }
      public int LeaveTypeID { get;set; }
      public decimal Numberoftimes { get;set; }
      public string Note { get;set; }
      public DateTime EDate { get;set; }
      public int CompanyID { get;set; }
      public int UserID { get;set; }
   }
}
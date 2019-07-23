using System.Collections.Generic;

namespace Hrms.Models
{
   public class ShiftManagemetinfoModel
   {
      public int Id { get;set; }
      public int ShiftID { get;set; }
      public string EmpCode { get;set; }
      public DateTime ShiftDate { get;set; }
      public string Note { get;set; }
      public string DDMMYYYY { get;set; }
      public string NextDate { get;set; }
      public int ShiftIDRostaring { get;set; }
      public int CompanyID { get;set; }
   }
}
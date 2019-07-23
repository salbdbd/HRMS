using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class View_LeaveEntitledViewModel
   {
      public int MaxDays { get;set; }
      public int LeaveType { get;set; }
      public string TypeName { get;set; }
      public string EmpCode { get;set; }
      public int CompanyID { get;set; }
   }
}
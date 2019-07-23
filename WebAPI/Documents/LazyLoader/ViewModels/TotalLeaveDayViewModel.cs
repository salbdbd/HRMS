using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class TotalLeaveDayViewModel
   {
      public string EmpCode { get;set; }
      public int Totalday { get;set; }
      public int AccepteDuration { get;set; }
      public int CompanyID { get;set; }
   }
}
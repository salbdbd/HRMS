using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class View_EnjoyViewModel
   {
      public string EmpCode { get;set; }
      public int Avail { get;set; }
      public int AvailCarry { get;set; }
      public int CompanyID { get;set; }
      public string TypeName { get;set; }
      public int MaxDays { get;set; }
   }
}
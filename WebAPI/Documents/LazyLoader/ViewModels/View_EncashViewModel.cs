using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class View_EncashViewModel
   {
      public string EmpCode { get;set; }
      public string EmpName { get;set; }
      public string Designation { get;set; }
      public string Department { get;set; }
      public string OfficeBranch { get;set; }
      public int Encashment { get;set; }
      public int CompanyID { get;set; }
      public string TypeName { get;set; }
      public int MaxDays { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class EmployeeInfoShortViewModel
   {
      public string EmpCode { get;set; }
      public string EmpName { get;set; }
      public int Gender { get;set; }
      public string Designation { get;set; }
      public string Department { get;set; }
      public string Type { get;set; }
      public string BusinessNature { get;set; }
      public DateTime BirthDate { get;set; }
      public DateTime JoiningDate { get;set; }
      public string OfficeBranch { get;set; }
      public string Status { get;set; }
      public int CompanyID { get;set; }
      public int id { get;set; }
      public int SortOrderDeg { get;set; }
      public int GradeValue { get;set; }
      public string Project { get;set; }
      public string IsBlock { get;set; }
   }
}
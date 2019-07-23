using System.Collections.Generic;

namespace Hrms.Models
{
   public class ProcessEmpSalaryMasterGratuityModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int SalaryPeridID { get;set; }
      public int DepartmentID { get;set; }
      public int DesignationID { get;set; }
      public int ProjectID { get;set; }
      public int BranchID { get;set; }
      public int PayscaleID { get;set; }
      public int CompanyID { get;set; }
      public int GradeValue { get;set; }
      public int Bank { get;set; }
      public nchar SalaryheadID { get;set; }
      public decimal Amount { get;set; }
   }
}
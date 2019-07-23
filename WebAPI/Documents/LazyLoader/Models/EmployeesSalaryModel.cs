using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmployeesSalaryModel
   {
      public int ID { get;set; }
      public int EmpID { get;set; }
      public string EmpCode { get;set; }
      public int StructureID { get;set; }
      public decimal Amount { get;set; }
      public decimal TaxAmount { get;set; }
      public int SalaryPeriodID { get;set; }
      public int FinYearID { get;set; }
      public string CreatedDate { get;set; }
      public string CreatedTime { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
      public int TaxYearID { get;set; }
      public string ChangeDate { get;set; }
      public int ChangePeriodID { get;set; }
      public int EffectPeriodID { get;set; }
   }
}
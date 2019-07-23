using System.Collections.Generic;

namespace Hrms.Models
{
   public class ProcessEmpSalaryStructureModel
   {
      public int ID { get;set; }
      public int EmpID { get;set; }
      public string EmpCode { get;set; }
      public int StructureID { get;set; }
      public int SalaryHeadID { get;set; }
      public int SalaryHeadType { get;set; }
      public int YearID { get;set; }
      public int TaxYearID { get;set; }
      public decimal Amount { get;set; }
      public int SalaryTypeID { get;set; }
      public int BasedOnID { get;set; }
      public string CreatedDate { get;set; }
      public int PeriodID { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
      public string PeriodName { get;set; }
   }
}
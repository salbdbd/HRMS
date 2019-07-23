using System.Collections.Generic;

namespace Hrms.Models
{
   public class ProcessEmpSalaryAdditionaModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int SalaryHeadID { get;set; }
      public int TaxYearID { get;set; }
      public decimal Amount { get;set; }
      public int PeriodID { get;set; }
      public int CompanyID { get;set; }
      public int isProjected { get;set; }
   }
}
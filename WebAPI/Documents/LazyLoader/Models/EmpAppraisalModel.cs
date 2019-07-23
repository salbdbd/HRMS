using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpAppraisalModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string RefEmpCode { get;set; }
      public int CompetenciesTypeID { get;set; }
      public int CompettenceID { get;set; }
      public string CompetenciesName { get;set; }
      public int PointID { get;set; }
      public decimal Point { get;set; }
      public int CompanyID { get;set; }
      public int UserID { get;set; }
      public int PeriodID { get;set; }
      public DateTime Date { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class SalaryYearModel
   {
      public int ID { get;set; }
      public string YearName { get;set; }
      public string StartDate { get;set; }
      public string EndDate { get;set; }
      public string CreatedDate { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
   }
}
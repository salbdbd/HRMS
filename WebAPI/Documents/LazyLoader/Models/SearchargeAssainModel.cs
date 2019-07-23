using System.Collections.Generic;

namespace Hrms.Models
{
   public class SearchargeAssainModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int TaxYearID { get;set; }
      public int PersentID { get;set; }
      public DateTime SDate { get;set; }
      public int CompanyID { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class TaxYearInfoModel
   {
      public int ID { get;set; }
      public string TaxYearName { get;set; }
      public string StartDate { get;set; }
      public string EndDate { get;set; }
      public int TaxInfoID { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
   }
}
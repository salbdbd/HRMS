using System.Collections.Generic;

namespace Hrms.Models
{
   public class MonthModel
   {
      public int ID { get;set; }
      public string MonthName { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
   }
}
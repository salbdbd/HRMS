using System.Collections.Generic;

namespace Hrms.Models
{
   public class BasedOnModel
   {
      public int ID { get;set; }
      public string BasedOnName { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class JobTypeModel
   {
      public int ID { get;set; }
      public string Description { get;set; }
      public int CompanyID { get;set; }
      public int SortOrder { get;set; }
      public int ISActive { get;set; }
   }
}
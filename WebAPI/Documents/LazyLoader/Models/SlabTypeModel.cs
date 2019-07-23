using System.Collections.Generic;

namespace Hrms.Models
{
   public class SlabTypeModel
   {
      public int ID { get;set; }
      public string SlabTypeName { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
   }
}
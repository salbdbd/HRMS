using System.Collections.Generic;

namespace Hrms.Models
{
   public class TypeModel
   {
      public int ID { get;set; }
      public string TypeName { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
   }
}
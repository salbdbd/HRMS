using System.Collections.Generic;

namespace Hrms.Models
{
   public class StructureTypeModel
   {
      public int ID { get;set; }
      public string StructureName { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
   }
}
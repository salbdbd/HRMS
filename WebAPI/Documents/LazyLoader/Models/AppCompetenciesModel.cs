using System.Collections.Generic;

namespace Hrms.Models
{
   public class AppCompetenciesModel
   {
      public int ID { get;set; }
      public string Description { get;set; }
      public string Details { get;set; }
      public int SortOrder { get;set; }
      public int APTypeID { get;set; }
   }
}
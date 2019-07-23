using System.Collections.Generic;

namespace Hrms.Models
{
   public class ProductionLineModel
   {
      public int ID { get;set; }
      public int FloreID { get;set; }
      public string Description { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
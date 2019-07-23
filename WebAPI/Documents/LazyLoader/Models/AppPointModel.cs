using System.Collections.Generic;

namespace Hrms.Models
{
   public class AppPointModel
   {
      public int ID { get;set; }
      public int ComID { get;set; }
      public int ComTypeID { get;set; }
      public int PointTypeID { get;set; }
      public string Description { get;set; }
      public decimal Point { get;set; }
   }
}
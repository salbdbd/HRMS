using System.Collections.Generic;

namespace Hrms.Models
{
   public class GLCostHeadModel
   {
      public int ID { get;set; }
      public string CostHead { get;set; }
      public int CompanyID { get;set; }
      public int CreateUser { get;set; }
   }
}
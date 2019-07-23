using System.Collections.Generic;

namespace Hrms.Models
{
   public class AssetNameModel
   {
      public int ID { get;set; }
      public int ACateoryID { get;set; }
      public string AssetName { get;set; }
      public string Description { get;set; }
      public int CompanyID { get;set; }
   }
}
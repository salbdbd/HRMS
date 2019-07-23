using System.Collections.Generic;

namespace Hrms.Models
{
   public class AssetSetupModel
   {
      public int ID { get;set; }
      public int AssetID { get;set; }
      public string Model { get;set; }
      public string Serial { get;set; }
      public decimal PurchesPrice { get;set; }
      public string Confiruration { get;set; }
      public string WarrentyType { get;set; }
      public DateTime Purchesate { get;set; }
      public DateTime Warrentydate { get;set; }
      public string Note { get;set; }
      public int Isactive { get;set; }
      public int CompanyID { get;set; }
   }
}
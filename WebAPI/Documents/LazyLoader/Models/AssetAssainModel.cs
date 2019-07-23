using System.Collections.Generic;

namespace Hrms.Models
{
   public class AssetAssainModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string ReciveFrom { get;set; }
      public int PropertyID { get;set; }
      public int ModelID { get;set; }
      public DateTime AssainDate { get;set; }
      public int AssainType { get;set; }
      public int Status { get;set; }
      public int CompanyID { get;set; }
      public string OwnershipDate { get;set; }
   }
}
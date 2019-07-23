using System.Collections.Generic;

namespace Hrms.Models
{
   public class TrainingSponsorTypeModel
   {
      public int ID { get;set; }
      public nchar Description { get;set; }
      public string Code { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
      public int ISActive { get;set; }
   }
}
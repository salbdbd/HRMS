using System.Collections.Generic;

namespace Hrms.Models
{
   public class BranchModel
   {
      public int ID { get;set; }
      public string Description { get;set; }
      public string Address { get;set; }
      public int Code { get;set; }
      public int CompanyID { get;set; }
      public int SortOrder { get;set; }
      public int ISActive { get;set; }
   }
}
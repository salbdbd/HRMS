using System.Collections.Generic;

namespace Hrms.Models
{
   public class UserBranchModel
   {
      public int ID { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
      public int BranchID { get;set; }
   }
}
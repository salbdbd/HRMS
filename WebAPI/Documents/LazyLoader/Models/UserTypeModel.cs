using System.Collections.Generic;

namespace Hrms.Models
{
   public class UserTypeModel
   {
      public int ID { get;set; }
      public string UserTypeName { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
   }
}
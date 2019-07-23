using System.Collections.Generic;

namespace Hrms.Models
{
   public class UserLogInfoModel
   {
      public int ID { get;set; }
      public string UserID { get;set; }
      public string LoginTime { get;set; }
      public string LogoutTime { get;set; }
      public int CompanyID { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class DataBackupLocationModel
   {
      public int ID { get;set; }
      public int CompanyID { get;set; }
      public string Location { get;set; }
      public int UserID { get;set; }
   }
}
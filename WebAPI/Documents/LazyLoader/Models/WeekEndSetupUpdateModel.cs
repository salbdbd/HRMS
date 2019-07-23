using System.Collections.Generic;

namespace Hrms.Models
{
   public class WeekEndSetupUpdateModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string WeekEndDay { get;set; }
      public DateTime SysDate { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
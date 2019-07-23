using System.Collections.Generic;

namespace Hrms.Models
{
   public class GCMSMSModel
   {
      public int ID { get;set; }
      public int GCM { get;set; }
      public int SMS { get;set; }
      public string CentralMobile { get;set; }
      public string ApplyerSMS { get;set; }
      public string ApplyToSMS { get;set; }
      public string ForwordToSMS { get;set; }
      public string CancelLeave { get;set; }
      public int CompanyID { get;set; }
   }
}
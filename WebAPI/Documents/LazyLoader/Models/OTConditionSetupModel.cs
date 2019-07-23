using System.Collections.Generic;

namespace Hrms.Models
{
   public class OTConditionSetupModel
   {
      public int ID { get;set; }
      public int EmployeeType { get;set; }
      public int MinimumOTHours { get;set; }
      public int MaxOTINADAY { get;set; }
      public int MaxOTInaMonth { get;set; }
      public DateTime sDate { get;set; }
      public string Note { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
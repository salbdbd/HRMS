using System.Collections.Generic;

namespace Hrms.Models
{
   public class OTCategorySetupModel
   {
      public int ID { get;set; }
      public string Name { get;set; }
      public decimal MinHour { get;set; }
      public decimal MaxHour { get;set; }
      public int DayType { get;set; }
      public int CompanyID { get;set; }
   }
}
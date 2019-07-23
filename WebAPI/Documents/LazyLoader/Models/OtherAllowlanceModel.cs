using System.Collections.Generic;

namespace Hrms.Models
{
   public class OtherAllowlanceModel
   {
      public int ID { get;set; }
      public int PayscaleID { get;set; }
      public int SalaryHeadID { get;set; }
      public decimal Amount { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class GratutyYearModel
   {
      public int ID { get;set; }
      public int Grade { get;set; }
      public decimal GYear { get;set; }
      public DateTime SDate { get;set; }
      public string Note { get;set; }
      public int CompanyID { get;set; }
   }
}
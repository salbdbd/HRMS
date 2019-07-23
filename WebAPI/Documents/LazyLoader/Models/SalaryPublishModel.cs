using System.Collections.Generic;

namespace Hrms.Models
{
   public class SalaryPublishModel
   {
      public int ID { get;set; }
      public int PeriodID { get;set; }
      public int Publish { get;set; }
      public int CompanyID { get;set; }
   }
}
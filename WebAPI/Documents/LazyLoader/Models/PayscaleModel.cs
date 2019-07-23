using System.Collections.Generic;

namespace Hrms.Models
{
   public class PayscaleModel
   {
      public int ID { get;set; }
      public string PayScale { get;set; }
      public nchar SalaryGradeID { get;set; }
      public int CompanyID { get;set; }
   }
}
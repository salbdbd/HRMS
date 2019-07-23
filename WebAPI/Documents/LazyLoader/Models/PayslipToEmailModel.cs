using System.Collections.Generic;

namespace Hrms.Models
{
   public class PayslipToEmailModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string EmailID { get;set; }
      public string FileName { get;set; }
      public string FileLocation { get;set; }
      public int PeriodID { get;set; }
      public string CreatedDate { get;set; }
      public int CompanyID { get;set; }
      public int Grade { get;set; }
   }
}
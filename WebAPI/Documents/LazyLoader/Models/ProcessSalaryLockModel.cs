using System.Collections.Generic;

namespace Hrms.Models
{
   public class ProcessSalaryLockModel
   {
      public int ID { get;set; }
      public int SalaryPeriod { get;set; }
      public DateTime LockDate { get;set; }
      public int CompanyID { get;set; }
      public int UserID { get;set; }
      public int EmpType { get;set; }
   }
}
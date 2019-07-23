using System.Collections.Generic;

namespace Hrms.Models
{
   public class ShiftAllowanceSetupModel
   {
      public int ID { get;set; }
      public int EmployeeType { get;set; }
      public int ShiftID { get;set; }
      public decimal Amount { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
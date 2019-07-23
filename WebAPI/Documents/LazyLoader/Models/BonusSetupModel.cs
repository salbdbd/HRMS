using System.Collections.Generic;

namespace Hrms.Models
{
   public class BonusSetupModel
   {
      public int ID { get;set; }
      public int JobType { get;set; }
      public int PaymentTypeID { get;set; }
      public int EmployeeTepe { get;set; }
      public int SalaryHead { get;set; }
      public decimal Number { get;set; }
      public DateTime BDate { get;set; }
      public string Note { get;set; }
      public int CompanyID { get;set; }
   }
}
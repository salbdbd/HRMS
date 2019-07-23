using System.Collections.Generic;

namespace Hrms.Models
{
   public class GratutySetupModel
   {
      public int ID { get;set; }
      public int Grade { get;set; }
      public int SalaryHead { get;set; }
      public decimal Numberofallowance { get;set; }
      public DateTime SDate { get;set; }
      public string Note { get;set; }
      public int CompanyID { get;set; }
   }
}
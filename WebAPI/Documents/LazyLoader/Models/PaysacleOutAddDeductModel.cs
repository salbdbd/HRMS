using System.Collections.Generic;

namespace Hrms.Models
{
   public class PaysacleOutAddDeductModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int SalaryHeadID { get;set; }
      public decimal Amount { get;set; }
      public DateTime StartDate { get;set; }
      public DateTime EndDate { get;set; }
      public int Allowancetype { get;set; }
      public int CompanyID { get;set; }
   }
}
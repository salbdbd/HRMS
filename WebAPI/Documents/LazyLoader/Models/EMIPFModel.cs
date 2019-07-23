using System.Collections.Generic;

namespace Hrms.Models
{
   public class EMIPFModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public decimal LoanAmount { get;set; }
      public decimal InterestRate { get;set; }
      public int LoanPeriod { get;set; }
      public int PERIOD { get;set; }
      public DateTime PAYDATE { get;set; }
      public decimal PAYMENT { get;set; }
      public decimal CURRENT_BALANCE { get;set; }
      public decimal INTEREST { get;set; }
      public decimal PRINCIPAL { get;set; }
      public int CompanyID { get;set; }
      public int UserID { get;set; }
      public int EMIID { get;set; }
   }
}
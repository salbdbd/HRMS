using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpLoanAdvanceCashPaymentModel
   {
      public int id { get;set; }
      public string EmpCode { get;set; }
      public DateTime PaymentDate { get;set; }
      public int SalaryHeadID { get;set; }
      public decimal PrincipleAmount { get;set; }
      public decimal Interest { get;set; }
      public decimal NetPayment { get;set; }
      public string Remarks { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
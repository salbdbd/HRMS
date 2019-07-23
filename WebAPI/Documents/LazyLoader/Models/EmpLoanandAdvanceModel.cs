using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpLoanandAdvanceModel
   {
      public int id { get;set; }
      public string EmpCode { get;set; }
      public string LoanDate { get;set; }
      public int SalaryHeadID { get;set; }
      public int InstallmentStart { get;set; }
      public decimal LoanAmount { get;set; }
      public decimal DownPayment { get;set; }
      public decimal NetLoan { get;set; }
      public int NoofInstallment { get;set; }
      public int InstallmentType { get;set; }
      public decimal Interest { get;set; }
      public decimal Installmentamount { get;set; }
      public string Remarks { get;set; }
      public int CompanyID { get;set; }
      public string DDMMYY { get;set; }
   }
}
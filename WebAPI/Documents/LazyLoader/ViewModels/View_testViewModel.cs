using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class View_testViewModel
   {
      public string EmpCode { get;set; }
      public int ID { get;set; }
      public int PayScaleID { get;set; }
      public int Bank { get;set; }
      public int BankBranch { get;set; }
      public string AccountNo { get;set; }
      public string AccountName { get;set; }
      public string Payby { get;set; }
      public string IncomeTax { get;set; }
      public decimal TaxDeductAmt { get;set; }
      public string ProvidentFund { get;set; }
      public int CompanyID { get;set; }
      public decimal PFDeductAmt { get;set; }
      public int EmpGradeID { get;set; }
   }
}
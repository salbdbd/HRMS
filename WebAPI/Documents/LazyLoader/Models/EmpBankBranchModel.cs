using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpBankBranchModel
   {
      public string EmpCode { get;set; }
      public string EmpName { get;set; }
      public string Designation { get;set; }
      public string AccountNo { get;set; }
      public string BankName { get;set; }
      public string BankBranch { get;set; }
      public int CompanyID { get;set; }
   }
}
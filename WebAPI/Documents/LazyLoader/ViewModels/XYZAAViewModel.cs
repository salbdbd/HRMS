using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class XYZAAViewModel
   {
      public string EmpCode { get;set; }
      public string EmpName { get;set; }
      public string Department { get;set; }
      public string Designation { get;set; }
      public decimal Amount { get;set; }
      public int CompanyID { get;set; }
      public int InstallmentStart { get;set; }
      public decimal Installmentamount { get;set; }
   }
}
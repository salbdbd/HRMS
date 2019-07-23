using System.Collections.Generic;

namespace Hrms.Models
{
   public class IncomeTaxReturnModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int TaxYearID { get;set; }
      public int CompanyID { get;set; }
      public string Date { get;set; }
      public string UserName { get;set; }
      public decimal WealthAmount { get;set; }
      public decimal TaxableIncome { get;set; }
      public decimal TaxPaid { get;set; }
      public string SerialNo { get;set; }
      public string CreateDate { get;set; }
   }
}
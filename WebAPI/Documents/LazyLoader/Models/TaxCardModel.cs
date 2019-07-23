using System.Collections.Generic;

namespace Hrms.Models
{
   public class TaxCardModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public decimal TotalIncome { get;set; }
      public int SalbID { get;set; }
      public decimal SlabAmount { get;set; }
      public decimal Taxable { get;set; }
      public decimal Tax { get;set; }
      public int Taxyear { get;set; }
      public int SlabType { get;set; }
      public int CompanyID { get;set; }
      public int RMonth { get;set; }
   }
}
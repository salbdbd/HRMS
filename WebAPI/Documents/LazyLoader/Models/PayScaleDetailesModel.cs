using System.Collections.Generic;

namespace Hrms.Models
{
   public class PayScaleDetailesModel
   {
      public int ID { get;set; }
      public int PayscaleID { get;set; }
      public int SalaryHeadID { get;set; }
      public int SalaryHeadType { get;set; }
      public int TaxYearID { get;set; }
      public decimal Amount { get;set; }
      public int SalaryTypeID { get;set; }
      public int BasedOnID { get;set; }
      public string CreatedDate { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
      public int Tag { get;set; }
   }
}
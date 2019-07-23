using System.Collections.Generic;

namespace Hrms.Models
{
   public class LoanDeductionStopModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int PeriodID { get;set; }
      public int LoanType { get;set; }
      public DateTime Date { get;set; }
      public string Remarks { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
      public DateTime EntryDAte { get;set; }
   }
}
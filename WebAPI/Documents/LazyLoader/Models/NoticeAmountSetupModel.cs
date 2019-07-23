using System.Collections.Generic;

namespace Hrms.Models
{
   public class NoticeAmountSetupModel
   {
      public int ID { get;set; }
      public int EmpGrade { get;set; }
      public int SalaryHead { get;set; }
      public decimal Numberoftimes { get;set; }
      public DateTime EDate { get;set; }
      public string Note { get;set; }
      public int CompanyID { get;set; }
      public int UserID { get;set; }
   }
}
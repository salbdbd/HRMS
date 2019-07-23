using System.Collections.Generic;

namespace Hrms.Models
{
   public class EarnLeaveSubstituteLeaveModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int LType { get;set; }
      public int YearID { get;set; }
      public int Qty { get;set; }
      public DateTime Date { get;set; }
      public string Note { get;set; }
      public int CompanyID { get;set; }
   }
}
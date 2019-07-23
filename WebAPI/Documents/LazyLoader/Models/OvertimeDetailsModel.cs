using System.Collections.Generic;

namespace Hrms.Models
{
   public class OvertimeDetailsModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int ShiftID { get;set; }
      public int PeriodID { get;set; }
      public string Login { get;set; }
      public string Logout { get;set; }
      public string Hour { get;set; }
      public string Others { get;set; }
      public decimal Otamount { get;set; }
      public string Note { get;set; }
      public int CompanyID { get;set; }
   }
}
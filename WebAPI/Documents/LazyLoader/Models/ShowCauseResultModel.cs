using System.Collections.Generic;

namespace Hrms.Models
{
   public class ShowCauseResultModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int ShowCauseTypeID { get;set; }
      public int ShowCauseResultID { get;set; }
      public DateTime StartDate { get;set; }
      public DateTime EndDate { get;set; }
      public DateTime Date { get;set; }
      public string Note { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
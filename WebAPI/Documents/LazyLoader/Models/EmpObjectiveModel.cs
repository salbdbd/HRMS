using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpObjectiveModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string Description { get;set; }
      public int YearID { get;set; }
      public int UserID { get;set; }
      public DateTime SysDate { get;set; }
      public int CompanyID { get;set; }
   }
}
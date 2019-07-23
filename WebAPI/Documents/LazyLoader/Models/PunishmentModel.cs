using System.Collections.Generic;

namespace Hrms.Models
{
   public class PunishmentModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public DateTime DateOfLetterIssue { get;set; }
      public int NatureOfPunishmentID { get;set; }
      public int ActionID { get;set; }
      public DateTime StartDate { get;set; }
      public DateTime EndDate { get;set; }
      public int sDays { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
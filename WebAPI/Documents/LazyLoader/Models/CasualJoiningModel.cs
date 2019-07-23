using System.Collections.Generic;

namespace Hrms.Models
{
   public class CasualJoiningModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public DateTime JoiningDate { get;set; }
      public DateTime CasualJoining { get;set; }
      public DateTime Date { get;set; }
      public int CompanyID { get;set; }
   }
}
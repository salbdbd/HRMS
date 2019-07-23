using System.Collections.Generic;

namespace Hrms.Models
{
   public class OTSupervisourModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string Supervisour { get;set; }
      public int UserID { get;set; }
      public DateTime EntryDate { get;set; }
      public int CompanyID { get;set; }
   }
}
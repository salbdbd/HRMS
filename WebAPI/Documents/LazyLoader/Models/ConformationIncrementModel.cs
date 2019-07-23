using System.Collections.Generic;

namespace Hrms.Models
{
   public class ConformationIncrementModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int Type { get;set; }
      public DateTime Date { get;set; }
      public int PrePayscaleID { get;set; }
      public int IncrementPacyscaleID { get;set; }
      public int CompanyID { get;set; }
   }
}
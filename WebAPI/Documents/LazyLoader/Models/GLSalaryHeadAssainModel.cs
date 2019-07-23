using System.Collections.Generic;

namespace Hrms.Models
{
   public class GLSalaryHeadAssainModel
   {
      public int ID { get;set; }
      public int CostHead { get;set; }
      public int SalaryHead { get;set; }
      public DateTime Date { get;set; }
      public string Note { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
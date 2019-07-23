using System.Collections.Generic;

namespace Hrms.Models
{
   public class CarHouseAssainModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public DateTime AssainDate { get;set; }
      public int Type { get;set; }
      public int Active { get;set; }
      public int CompanyID { get;set; }
   }
}
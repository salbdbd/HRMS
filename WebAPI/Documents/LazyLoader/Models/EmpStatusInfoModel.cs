using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpStatusInfoModel
   {
      public int ID { get;set; }
      public string Description { get;set; }
      public string StatusCode { get;set; }
      public int CompanyID { get;set; }
      public int ISActive { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class KPISetupModel
   {
      public int ID { get;set; }
      public string KPIName { get;set; }
      public int DepartmentId { get;set; }
      public int SerialNo { get;set; }
      public int KPIType { get;set; }
      public int CompanyID { get;set; }
      public int UserID { get;set; }
      public DateTime CreateDate { get;set; }
      public DateTime UpdateDate { get;set; }
   }
}
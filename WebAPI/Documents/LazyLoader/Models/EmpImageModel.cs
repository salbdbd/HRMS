using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpImageModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public image EmpImage { get;set; }
      public image Signature { get;set; }
      public int CompanyID { get;set; }
   }
}
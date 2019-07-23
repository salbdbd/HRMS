using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpCertificateUploadModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int EducationLevelID { get;set; }
      public byte[] CImage { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
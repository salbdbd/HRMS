using System.Collections.Generic;

namespace Hrms.Models
{
   public class UploadDocumentsModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string Name { get;set; }
      public string type { get;set; }
      public byte[] data { get;set; }
      public DateTime Date { get;set; }
      public int DocumentType { get;set; }
      public int CompanyID { get;set; }
   }
}
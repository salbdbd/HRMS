using System.Collections.Generic;

namespace Hrms.Models
{
   public class UploadDocumentInFolderModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string FileName { get;set; }
      public string FilePath { get;set; }
      public int CompanyID { get;set; }
      public DateTime SystemDate { get;set; }
      public int UserID { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class DepartmentGLModel
   {
      public int ID { get;set; }
      public string Description { get;set; }
      public string Code { get;set; }
      public int SortOrder { get;set; }
      public string GLCode { get;set; }
      public int CompanyID { get;set; }
      public int ISActive { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class SalaryTypeModel
   {
      public int ID { get;set; }
      public string SalaryTypeName { get;set; }
      public string CreatedDate { get;set; }
      public int SortOrder { get;set; }
      public int CompanyID { get;set; }
   }
}
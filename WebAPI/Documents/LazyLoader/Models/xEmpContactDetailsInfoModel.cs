using System.Collections.Generic;

namespace Hrms.Models
{
   public class xEmpContactDetailsInfoModel
   {
      public int id { get;set; }
      public string EmpCode { get;set; }
      public string PreAddress { get;set; }
      public string ParAddress { get;set; }
      public string PreStreet { get;set; }
      public string ParStreet { get;set; }
      public string PreCity { get;set; }
      public string ParCity { get;set; }
      public string Mobile { get;set; }
      public string Phone { get;set; }
      public string AnotherContact { get;set; }
      public string Country { get;set; }
      public int CompanyID { get;set; }
   }
}
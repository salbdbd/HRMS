using System.Collections.Generic;

namespace Hrms.Models
{
   public class tblEmpProQualificationModel
   {
      public bigint ID { get;set; }
      public string EmpCode { get;set; }
      public string Certification { get;set; }
      public string Institute { get;set; }
      public string Location { get;set; }
      public int CountryID { get;set; }
      public DateTime FromDate { get;set; }
      public DateTime ToDate { get;set; }
      public string Duration { get;set; }
      public string Achievement { get;set; }
      public int CompanyID { get;set; }
   }
}
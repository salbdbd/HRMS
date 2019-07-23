using System.Collections.Generic;

namespace Hrms.Models
{
   public class CompanyInfoModel
   {
      public int ID { get;set; }
      public string CompanyName { get;set; }
      public string CompanyAddress { get;set; }
      public string Phone { get;set; }
      public string Code { get;set; }
      public string TIN { get;set; }
      public string WebAddress { get;set; }
      public string Email { get;set; }
      public int Salarytype { get;set; }
      public byte[] CompanyLogo { get;set; }
      public byte[] ReportLogo { get;set; }
   }
}
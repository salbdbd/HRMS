using System.Collections.Generic;

namespace Hrms.Models
{
   public class InsuranceCoverageModel
   {
      public int ID { get;set; }
      public int GradeID { get;set; }
      public decimal Amount { get;set; }
      public int CompanyID { get;set; }
      public string Name { get;set; }
      public string Designation { get;set; }
      public string Depertment { get;set; }
      public string InsuranceCompany { get;set; }
      public string Address { get;set; }
      public string INSNumber { get;set; }
   }
}
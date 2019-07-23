using System.Collections.Generic;

namespace Hrms.Models
{
   public class ExperenceInformationModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string Organization { get;set; }
      public string Address { get;set; }
      public string JoinDate { get;set; }
      public string EndDate { get;set; }
      public string YearOfExperience { get;set; }
      public string Position { get;set; }
      public string Designation { get;set; }
      public string PhoneNo { get;set; }
      public string JobDescription { get;set; }
      public string SupervisorName { get;set; }
      public string SupervisorMobileNo { get;set; }
      public int CompanyID { get;set; }
   }
}
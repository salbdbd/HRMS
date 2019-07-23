using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpHospitalizationModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string AdmissionDate { get;set; }
      public string PatientName { get;set; }
      public string Relation { get;set; }
      public string DOB { get;set; }
      public string Occupation { get;set; }
      public string Address { get;set; }
      public string NationalID { get;set; }
      public string MobileNo { get;set; }
      public string Email { get;set; }
      public byte[] Photo { get;set; }
      public int CompanyID { get;set; }
   }
}
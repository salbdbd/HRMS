using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class EmpinfowithPictureViewModel
   {
      public string EmpCode { get;set; }
      public string EmpName { get;set; }
      public int Gender { get;set; }
      public string Designation { get;set; }
      public string Resident { get;set; }
      public string Department { get;set; }
      public string Type { get;set; }
      public DateTime BirthDate { get;set; }
      public DateTime JoiningDate { get;set; }
      public string Status { get;set; }
      public string StatusDate { get;set; }
      public string TINNo { get;set; }
      public string NationalId { get;set; }
      public string IsCompanyCar { get;set; }
      public int CompanyID { get;set; }
      public int id { get;set; }
      public int SortOrderdep { get;set; }
      public int SortOrderDeg { get;set; }
      public int GradeValue { get;set; }
      public int GradeID { get;set; }
      public string Division { get;set; }
      public int DepartmentID { get;set; }
      public int DesignationID { get;set; }
      public string IsBlock { get;set; }
      public byte[] Picture { get;set; }
      public string Location { get;set; }
   }
}
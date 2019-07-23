using System.Collections.Generic;

namespace Hrms.Models
{
   public class UsersModel
   {
      public int ID { get;set; }
      public string UserName { get;set; }
      public string LoginID { get;set; }
      public string LoginPassword { get;set; }
      public int UserTypeID { get;set; }
      public int CreatedByID { get;set; }
      public string CreatedDate { get;set; }
      public string IsChangedPassword { get;set; }
      public string IsActive { get;set; }
      public string EmpCode { get;set; }
      public int CompanyID { get;set; }
      public int GradeValue { get;set; }
      public int Salarytype { get;set; }
   }
}
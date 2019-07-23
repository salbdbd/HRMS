using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class UserViewViewModel
   {
      public int ID { get;set; }
      public string UserName { get;set; }
      public string LoginID { get;set; }
      public string LoginPassword { get;set; }
      public int UserTypeID { get;set; }
      public string EmpCode { get;set; }
      public int GradeValue { get;set; }
   }
}
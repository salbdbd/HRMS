using System.Collections.Generic;

namespace Hrms.Models
{
   public class UserAccessPageEmpModel
   {
      public int ID { get;set; }
      public int UserID { get;set; }
      public string EmpCode { get;set; }
      public int CompanyID { get;set; }
      public int BranchID { get;set; }
      public bit IsAccess { get;set; }
      public int UserTypeID { get;set; }
      public string PageName { get;set; }
      public int PageID { get;set; }
      public int MenuID { get;set; }
   }
}
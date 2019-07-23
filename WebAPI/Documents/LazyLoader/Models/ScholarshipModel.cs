using System.Collections.Generic;

namespace Hrms.Models
{
   public class ScholarshipModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string NameofScholarship { get;set; }
      public string Institute { get;set; }
      public string Duration { get;set; }
      public int Country { get;set; }
      public string Achievment { get;set; }
      public DateTime AchievmentDate { get;set; }
      public string Remark { get;set; }
      public int UserID { get;set; }
      public int CompanyID { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class tblJobDescriptionModel
   {
      public bigint ID { get;set; }
      public string EmpCode { get;set; }
      public string Description { get;set; }
      public DateTime JobAssignDate { get;set; }
      public DateTime InactiveDate { get;set; }
      public int CompanyID { get;set; }
      public int Status { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class AppsAttandanceSetupModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string Location { get;set; }
      public string Latitude { get;set; }
      public string Longitude { get;set; }
      public int Status { get;set; }
      public int Distance { get;set; }
      public int UserID { get;set; }
      public DateTime systemDate { get;set; }
      public int CompanyID { get;set; }
   }
}
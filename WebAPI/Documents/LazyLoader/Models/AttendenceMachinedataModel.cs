using System.Collections.Generic;

namespace Hrms.Models
{
   public class AttendenceMachinedataModel
   {
      public int ID { get;set; }
      public string Date { get;set; }
      public string Time { get;set; }
      public string EmpCode { get;set; }
      public string TerminalID { get;set; }
      public int CompanyID { get;set; }
      public string GPRSLocation { get;set; }
      public string Latitude { get;set; }
      public string Longitude { get;set; }
      public string Distance { get;set; }
   }
}
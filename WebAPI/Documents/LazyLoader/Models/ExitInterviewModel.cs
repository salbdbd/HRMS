using System.Collections.Generic;

namespace Hrms.Models
{
   public class ExitInterviewModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int LeavingID { get;set; }
      public string InterViewer { get;set; }
      public string DateOfInterview { get;set; }
      public decimal ReasonPerchentage { get;set; }
      public int OutOfPayroll { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.Models
{
   public class OTRequisitionModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int ShiftID { get;set; }
      public int OTHours { get;set; }
      public int UserID { get;set; }
      public DateTime OTDate { get;set; }
      public string DDMMYY { get;set; }
      public int CompanyID { get;set; }
      public string ApprovedBY { get;set; }
      public int AproveType { get;set; }
      public int ApprovedHours { get;set; }
   }
}
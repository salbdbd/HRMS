using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpProductionPositionModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int MachineID { get;set; }
      public DateTime PositionDate { get;set; }
      public int UserID { get;set; }
      public string Note { get;set; }
      public int CompanyID { get;set; }
   }
}
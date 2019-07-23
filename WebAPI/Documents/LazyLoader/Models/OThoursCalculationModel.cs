using System.Collections.Generic;

namespace Hrms.Models
{
   public class OThoursCalculationModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public string LogoutTime { get;set; }
      public decimal Hourr { get;set; }
      public decimal Minutee { get;set; }
      public string DDMMYYYY { get;set; }
      public decimal OTHours { get;set; }
      public decimal PropostHours { get;set; }
      public DateTime Date { get;set; }
      public int CompanyID { get;set; }
      public string Remarks { get;set; }
   }
}
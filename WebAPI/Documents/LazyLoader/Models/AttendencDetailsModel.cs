using System.Collections.Generic;

namespace Hrms.Models
{
   public class AttendencDetailsModel
   {
      public int ID { get;set; }
      public int PerID { get;set; }
      public string EmpCod { get;set; }
      public string AttnDate { get;set; }
      public string AttnTime { get;set; }
      public int TYPEE { get;set; }
      public decimal Hourr { get;set; }
      public decimal Minutee { get;set; }
      public decimal Secondd { get;set; }
      public string DDMMYYYY { get;set; }
      public string MachineName { get;set; }
      public int CompanyID { get;set; }
   }
}
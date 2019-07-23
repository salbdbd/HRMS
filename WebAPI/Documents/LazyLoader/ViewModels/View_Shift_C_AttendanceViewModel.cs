using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class View_Shift_C_AttendanceViewModel
   {
      public string PerID { get;set; }
      public string EmpCode { get;set; }
      public string ShiftDate { get;set; }
      public string EventTime { get;set; }
      public int Status { get;set; }
      public int ShiftID { get;set; }
      public int Hour { get;set; }
      public int Minute { get;set; }
      public int Second { get;set; }
      public string DDMMYYYY { get;set; }
      public string MachineName { get;set; }
   }
}
using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class View_3ViewModel
   {
      public string ShiftDate { get;set; }
      public int ShiftID { get;set; }
      public string EmpCode { get;set; }
      public string ShfitName { get;set; }
      public time ShiftStartHour { get;set; }
      public time ShiftStartMin { get;set; }
      public time ShiftEndtHour { get;set; }
      public time ShiftEndMin { get;set; }
      public decimal ManagementBenifit { get;set; }
      public decimal NonManagementBenifit { get;set; }
   }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSModelDbCotext.Attendance.Model
{
  class ShiftSetupModel
  {
    public int Id { get; set; }
    public string ShfitName { get; set; }
    public string ShiftStartHour { get; set; }
    public string ShiftStartMin { get; set; }
    public string ShiftEndtHour { get; set; }
    public string ShiftEndMin { get; set; }
    public string MinLogout { get; set; }
    public string MaxLogout { get; set; }
    public string MinIntime { get; set; }
    public string MaxIntime { get; set; }
    public int Out { get; set; }
    public int NextDate { get; set; }
    public int CompanyID { get; set; }
    public int NextShiftID { get; set; }
    public int DutyHours { get; set; }
    public int DutyMinute { get; set; }
    public string Msg { get; set; }
    public int pOptions { get; set; }

  }
}

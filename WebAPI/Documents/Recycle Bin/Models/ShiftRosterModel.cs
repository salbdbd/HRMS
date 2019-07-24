using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSModelDbCotext.Attendance.Model
{
  class ShiftRosterModel
  {
    public int ShiftID { get; set; }
    public string EmpCode { get; set; }
    public DateTime ShiftDate { get; set; }
    public string Note { get; set; }
    public string DDMMYYYY { get; set; }
    public string NextDate { get; set; }
    public int ShiftIDRostaring { get; set; }
    public int CompanyID { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSModelDbCotext.Attendance.Model
{
  class MonthlyAttendanceModel
  {
    public string StrDate { get; set; }
    public string EndDate { get; set; }
    public int CompanyID { get; set; }
    public int Grade { get; set; }
    public int Depertment { get; set; }
    public int Branch { get; set; }
    public int Project { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSModelDbCotext.Attendance.Model
{
  class ApplicationForAttendanceModel
  {
    public int ID { get; set; }
    public string EmpCode { get; set; }
    public string Reason { get; set; }
    public DateTime AttnDate { get; set; }
    public string InTime { get; set; }
    public string OutTime { get; set; }
    public int ApproveType { get; set; }
    public int UserID { get; set; }
    public int CompanyID { get; set; }
    public int AttendanceID { get; set; }
    public string ReqFrom { get; set; }
    public string ReqTo { get; set; }
    public string Msg { get; set; }
    public int pOptions { get; set; }
  }
}

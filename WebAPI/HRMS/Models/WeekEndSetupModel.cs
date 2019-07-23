using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSModelDbCotext.Attendance.Model
{
  class WeekEndSetupModel
  {
    public int ID { get; set; }
    public string EmpCode { get; set; }
    public string WeekEndDay { get; set; }
    public int UserID { get; set; }
    public int CompanyID { get; set; }
    public int GradeValue { get; set; }
    public int DepartmentID { get; set; }
    public int DesignationID { get; set; }
    public int Location { get; set; }
    public int BranchID { get; set; }
    public string Msg { get; set; }
    public int pOptions { get; set; }
  }
}

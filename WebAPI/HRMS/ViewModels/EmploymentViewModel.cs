using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRMS.Models.HR;

namespace HRMS.ViewModels
{
  public class EmploymentViewModel:EmploymentModel
  {
    public string EmpName { get; set; }
    public string BusinessNature { get; set; }
    public string Department { get; set; }
    public string Designation { get; set; }
    public string GradeName { get; set; }
    public int GradeValue { get; set; }
    public string ProjectName { get; set; }
    public string CompanyName { get; set; }
  }
}

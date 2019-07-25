using HRMS.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.ViewModels.HR.Employee
{
  public class EmpFamilyInfoVM:EmpFamilyInfoModel
  {
    public string GenderName { get; set; }
    public double UsedPer { get; set; }
    public double UnusedPer { get; set; }
    public int NomineeCount { get; set; }
    public string BloodGroupName { get; set; }
    public string MaritalStatusName { get; set; }
  }
}

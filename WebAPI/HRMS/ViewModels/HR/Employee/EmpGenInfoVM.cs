using HRMS.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.ViewModels.HR.Employee
{
  public class EmpGenInfoVM:EmpGenInfoModel
  {
    public string FullName { get; set; }
    public string FirstName { get; set; }
    public string NickName { get; set; }
    public string FatherName { get; set; }
    public string MoitherName { get; set; }
    public string SpouseName { get; set; }
    public string MaritalStatus { get; set; }
    public int GenderID { get; set; }
    public int BloodGroupID { get; set; }
    public int ReligionID { get; set; }
    public int MaritalStatusID { get; set; }
    public int NationalityID { get; set; }
    public int MotherOccupationID { get; set; }
    public int FatherOccupationID { get; set; }
  }
}

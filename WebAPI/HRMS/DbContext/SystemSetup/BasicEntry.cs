using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper.Framework;
using HRMS.Models.SyetemSetup;

namespace HRMS.DbContext.SystemSetup
{
  public class BasicEntry
  {
    //Bank Branch
    public static List<BasicEntryModel> GetBank()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Bank").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetDepartment()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Department").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetDepartmentGL()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM DepartmentGL").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetSection()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM BusinessNature").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetLocation()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Location").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetCountry()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Country").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetNationality()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Nationality").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetGender()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Gender").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetReligion()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Religion").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetBloodGroup()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM BloodGroup").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetEducation()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM EducationLevel").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetEducationBoard()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM EducationBoard").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetInstitute()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Institute").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetResult()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Result").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetPassingYear()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM PassingYear").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetTrainingType()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM TrainingType").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetTrainingCountry()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM TrainingCountry").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetTrainingInstitute()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM TrainingInstitute").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetTrainingNature()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM TrainingNature").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetTrainingSponserBy()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM TrainingSponsorType").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetProject()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Project").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetJobType()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM JobType").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetDesignation()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Designation").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetOccupation()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Occupation").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetExperienceType()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM ExperienceType").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetPunishment()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Punishment").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetBranch()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Branch").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetUnit()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Unit").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetSignatory()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Signatory").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetMisconduct()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Signatory").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetPrefix()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Prefix").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetSuffix()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM Suffix").ToList();
      return (data);
    }
    public static List<BasicEntryModel> GetPublicationType()
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var data = conn.Query<BasicEntryModel>("SELECT * FROM PublicationType").ToList();
      return (data);
    }
  }

}

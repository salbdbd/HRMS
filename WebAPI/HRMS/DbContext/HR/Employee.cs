using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper.Framework;
using HRMS.Helper;
using HRMS.Models.Employee;
using HRMS.ViewModels;
using HRMS.ViewModels.HR.Employee;

namespace HRMS.DbContext
{
  public static class Employee
  {
    //General Info
    public static bool SaveEmpGenInfo(EmpGenInfoModel empGen)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var empGenObj = new
        {
          empGen.EmpCode,
          empGen.EmpName,
          empGen.LastName,
          empGen.ShortName,
          empGen.FName,
          empGen.FatherOccupation,
          empGen.MotherOccupation,
          empGen.MName,
          empGen.WifeName,
          empGen.Nationality,
          empGen.Weight,
          empGen.Height,
          empGen.Gender,
          empGen.DOB,
          empGen.NationalId,
          empGen.TINNo,
          empGen.Religion,
          empGen.meritalStatus,
          empGen.PasportNo,
          empGen.BloodGroup,
          empGen.Remarks,
          empGen.CompanyID,
          empGen.GradeValue,
          empGen.Picture,
          empGen.Signature,
          empGen.PassportExpairedDate,
          empGen.Title,
          empGen.Suffix,
          empGen.Child,
          empGen.PassportIssueDate
        };
        int rowAffect = con.Execute("sp_EmpGeneralInfo_Insert", param: empGenObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }
    public static EmpGenInfoModel GetEmpGenInfo(int gradeVal, int companyId, string empCode)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        object paramObj = new
        {
          GradeValue = gradeVal,
          CompanyID = companyId,
          EmpCode = empCode
        };
        EmpGenInfoModel employee = con.QuerySingle<EmpGenInfoModel>("SELECT * FROM EmpGeneralInfo WHERE GradeValue='"+gradeVal+"' AND EmpCode='"+empCode+"' AND CompanyID="+companyId);
        employee.Age = AgeCalculator.CalculateAge(employee.DOB);
        return employee;
      }
    }
    public static bool UpdateEmpGenInfo(EmpGenInfoModel empGen)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var empGenObj = new
        {
          empGen.EmpCode,
          empGen.EmpName,
          empGen.LastName,
          empGen.ShortName,
          empGen.FName,
          empGen.FatherOccupation,
          empGen.MotherOccupation,
          empGen.MName,
          empGen.WifeName,
          empGen.Nationality,
          empGen.Weight,
          empGen.Height,
          empGen.Gender,
          empGen.DOB,
          empGen.NationalId,
          empGen.TINNo,
          empGen.Religion,
          empGen.meritalStatus,
          empGen.PasportNo,
          empGen.BloodGroup,
          empGen.Remarks,
          empGen.CompanyID,
          empGen.GradeValue,
          empGen.Picture,
          empGen.Signature,
          empGen.PassportExpairedDate,
          empGen.Title,
          empGen.Suffix,
          empGen.Child,
          empGen.PassportIssueDate
        };
        int rowAffect = con.Execute("sp_EmpGeneralInfo_Update", param: empGenObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }

    //Contact Info
    public static bool SaveEmpContactInfo(EmpContactInfoModel empContact)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          empContact.EmpCode,
          empContact.MobileNo,
          empContact.PhoneNo,
          empContact.Email,
          empContact.PreThanaID,
          empContact.PerThanaID,
          empContact.PrePostOffice,
          empContact.PerPostOffice,
          empContact.PreVillage,
          empContact.PerVillage,
          empContact.PersonName,
          empContact.PersonContact,
          empContact.PersonAddress,
          empContact.CompanyID,
          empContact.Relationship,
          empContact.PreCountry,
          empContact.PerCountry,
          empContact.PrePostCode,
          empContact.PerPostCode,
          empContact.MailingAddress,
          empContact.SecondaryMobile,
          empContact.SecandaryMail,
          empContact.SocialURL1,
          empContact.SocialURL2,
          empContact.EmergrncyPostCode,
          empContact.EmergrncyPostCountry
        };
        int rowAffect = con.Execute("sp_EmpContactInfo_Insert", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }
    public static bool UpdateEmpContactInfo(EmpContactInfoModel empContact)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          empContact.ID,
          empContact.EmpCode,
          empContact.MobileNo,
          empContact.PhoneNo,
          empContact.Email,
          empContact.PreThanaID,
          empContact.PerThanaID,
          empContact.PrePostOffice,
          empContact.PerPostOffice,
          empContact.PreVillage,
          empContact.PerVillage,
          empContact.PersonName,
          empContact.PersonContact,
          empContact.PersonAddress,
          empContact.CompanyID,
          empContact.Relationship,
          empContact.PreCountry,
          empContact.PerCountry,
          empContact.PrePostCode,
          empContact.PerPostCode,
          empContact.MailingAddress,
          empContact.SecondaryMobile,
          empContact.SecandaryMail,
          empContact.SocialURL1,
          empContact.SocialURL2,
          empContact.EmergrncyPostCode,
          empContact.EmergrncyPostCountry
        };
        int rowAffect = con.Execute("sp_EmpContactInfo_Update", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }

    //Family Info
    public static bool SaveEmpFamilyInfo(EmpFamilyInfoModel empFamily)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          empFamily.EmpCode,
          empFamily.PersonName,
          empFamily.DOB,
          empFamily.POB,
          empFamily.BloodGroup,
          empFamily.Relationship,
          empFamily.Gender,
          empFamily.MaritalStatus,
          empFamily.ContactNo,
          empFamily.Email,
          empFamily.Nationality,
          empFamily.IsNominee,
          empFamily.Percentage,
          empFamily.Occupation,
          empFamily.PassportNo,
          empFamily.NationalID,
          empFamily.CompanyID,
          empFamily.Photo
        };
        int rowAffect = con.Execute("sp_EmpFamilyInfo_Insert", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;

      }
    }
    public static bool UpdateEmpFamilyInfo(EmpFamilyInfoModel empFamily)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          empFamily.ID,
          empFamily.EmpCode,
          empFamily.PersonName,
          empFamily.DOB,
          empFamily.POB,
          empFamily.BloodGroup,
          empFamily.Relationship,
          empFamily.Gender,
          empFamily.MaritalStatus,
          empFamily.ContactNo,
          empFamily.Email,
          empFamily.Nationality,
          empFamily.IsNominee,
          empFamily.Percentage,
          empFamily.Occupation,
          empFamily.PassportNo,
          empFamily.NationalID,
          empFamily.CompanyID,
          empFamily.Photo
        };
        int rowAffect = con.Execute("sp_EmpFamilyInfo_Update", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }
    public static List<EmpFamilyInfoVM> GetEmpFamilyInfo( int companyId,string empCode)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          CompanyID = companyId,
          EmpCode = empCode
        };
        List<EmpFamilyInfoVM> familyMember = con.Query<EmpFamilyInfoVM>("sp_EmpFamilyInfo_List", param: paramObj, commandType:CommandType.StoredProcedure).ToList();
        return familyMember;
      }
    }
    public static EmpFamilyInfoModel GetFamilyMember(int personId)
    {
      using(var con = new SqlConnection(Connection.ConnectionString()))
      {
        EmpFamilyInfoModel person = con.QuerySingle<EmpFamilyInfoModel>("SELECT * FROM EmpFamilyInfo WHERE ID = " + personId);
        return person;
      }
    }

    //Reference Info
    public static bool SaveEmpRef(EmpReferenceModel empRef)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          empRef.EmpCode,
          empRef.Name,
          empRef.Organization,
          empRef.Designation,
          empRef.Relationship,
          empRef.Address,
          empRef.Mobile,
          empRef.Email,
          empRef.CompanyID
        };
        int rowAffect = con.Execute("sp_EmployeeReference_Insert", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }
    public static bool UpdateEmpRef(EmpReferenceModel empRef)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          empRef.Id,
          empRef.EmpCode,
          empRef.Name,
          empRef.Organization,
          empRef.Designation,
          empRef.Relationship,
          empRef.Address,
          empRef.Mobile,
          empRef.Email,
          empRef.CompanyID

        };
        int rowAffect = con.Execute("sp_EmployeeReference_Update", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }

    //Education Info
    public static bool SaveEmpEducation(EmpEducationInfoModel empEdu)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          empEdu.EmpCode,
          empEdu.Name,
          empEdu.Levelof,
          empEdu.Institute,
          empEdu.Pasyear,
          empEdu.Marks,
          empEdu.Duration,
          empEdu.Subject,
          empEdu.Result,
          empEdu.Achivement,
          empEdu.CompanyID,
          empEdu.EducationBoard,
          empEdu.Country
        };
        int rowAffect = con.Execute("sp_Education_Insert", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }
    public static bool UpdateEmpEducation(EmpEducationInfoModel empEdu)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          empEdu.ID,
          empEdu.EmpCode,
          empEdu.Name,
          empEdu.Levelof,
          empEdu.Institute,
          empEdu.Pasyear,
          empEdu.Marks,
          empEdu.Duration,
          empEdu.Subject,
          empEdu.Result,
          empEdu.Achivement,
          empEdu.CompanyID,
          empEdu.EducationBoard,
          empEdu.Country
        };
        int rowAffect = con.Execute("sp_Education_Update", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }

    //Experience Info
    public static bool SaveEmpExperience(EmpExperienceModel empExp)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          empExp.EmpCode,
          empExp.Organization,
          empExp.Address,
          empExp.JoinDate,
          empExp.EndDate,
          empExp.YearOfExperience,
          empExp.Position,
          empExp.PhoneNo,
          empExp.JobDescription,
          empExp.SupervisorName,
          empExp.SupervisorMobileNo,
          empExp.CompanyID,
          empExp.CountryID,
          empExp.ExprienceType
        };
        int rowAffect = con.Execute("sp_Experience_Insert", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }
    public static bool UpdateEmpExperience(EmpExperienceModel empExp)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          ID = empExp.Id,
          empExp.EmpCode,
          empExp.Organization,
          empExp.Address,
          empExp.JoinDate,
          empExp.EndDate,
          empExp.YearOfExperience,
          empExp.Position,
          empExp.PhoneNo,
          empExp.JobDescription,
          empExp.SupervisorName,
          empExp.SupervisorMobileNo,
          empExp.CompanyID,
          empExp.CountryID,
          empExp.ExprienceType
        };
        int rowAffect = con.Execute("sp_Experience_Update", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }

    //Qualification Info
    public static bool SaveEmpQualification(EmpQualificationModel eQ)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          eQ.ID,
          eQ.EmpCode,
          eQ.Certification,
          eQ.Institute,
          eQ.Location,
          eQ.CountryID,
          eQ.FromDate,
          eQ.ToDate,
          eQ.Duration,
          eQ.Achievement,
          eQ.CompanyID,
          eQ.Msg,
          eQ.pOptions
        };
        int rowAffect = con.Execute("sp_EmpQualification_New", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }
    public static bool SaveEmpPublication(EmpPublicationModel eP)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          eP.EmpCode,
          eP.PublicationTitle,
          eP.WherePublished,
          eP.SingleMultiple,
          eP.LocalOrIntl,
          eP.Contribution,
          eP.Remarks,
          eP.PublicationDate,
          eP.CompanyID,
          eP.PublicationType,
          eP.URL,
          eP.Photo,
          eP.Numberofauthor,
          eP.DesignationId
        };
        int rowAffect = con.Execute("sp_Publication_Insert", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }

    //Publication Info
    public static bool UpdateEmpPublication(EmpPublicationModel eP)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          eP.ID,
          eP.EmpCode,
          eP.PublicationTitle,
          eP.WherePublished,
          eP.SingleMultiple,
          eP.LocalOrIntl,
          eP.Contribution,
          eP.Remarks,
          eP.PublicationDate,
          eP.CompanyID,
          eP.PublicationType,
          eP.URL,
          eP.Photo,
          eP.Numberofauthor,
          eP.DesignationId
        };
        int rowAffect = con.Execute("sp_Publication_Update", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }
    public static bool SaveEmpScholarship(EmpScholarshipModel eS)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          eS.ID,
          eS.EmpCode,
          eS.NameofScholarship,
          eS.Institute,
          eS.Duration,
          eS.Country,
          eS.Achievment,
          eS.AchievmentDate,
          eS.Remark,
          eS.UserID,
          eS.CompanyID,
          eS.Msg,
          eS.pOptions
        };
        int rowAffect = con.Execute("sp_Scholarship_New", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }

    //Training Info
    public static bool SaveEmpTraining(EmpTrainingModel eT)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          eT.EmpCode,
          eT.TrainingType,
          eT.TrainingName,
          eT.TrainingNature,
          eT.Description,
          eT.Institution,
          eT.TrainingPlace,
          eT.Country,
          eT.Achievement,
          eT.SponsorType,
          eT.TrainingFees,
          eT.OtherCost,
          eT.FromDate,
          eT.ToDate,
          eT.CompanyID
        };
        int rowAffect = con.Execute("sp_Scholarship_New", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }
    public static bool UpdateEmpTraining(EmpTrainingModel eT)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          eT.ID,
          eT.EmpCode,
          eT.TrainingType,
          eT.TrainingName,
          eT.TrainingNature,
          eT.Description,
          eT.Institution,
          eT.TrainingPlace,
          eT.Country,
          eT.Achievement,
          eT.SponsorType,
          eT.TrainingFees,
          eT.OtherCost,
          eT.FromDate,
          eT.ToDate,
          eT.CompanyID
        };
        int rowAffect = con.Execute("sp_EmpTraining_Update", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }

    //Employment Info
    public static bool SaveEmployment(EmpEmploymentModel emp)
    {
      using (var con = new SqlConnection())
      {
        var paramObj = new
        {
          emp.EmpCode,
          emp.CompanyID,
          emp.BusinessNatureID,
          emp.DesignationID,
          emp.JoinDate,
          emp.JobType,
          emp.EmpGradeID,
          emp.JobDescription,
          emp.JobLocation,
          emp.ProjectID,
          emp.DepartmentID,
          emp.ConfirmationDate,
          emp.ConfirmationDueDate,
          emp.CardNo,
          emp.Experience,
          emp.Resident,
          emp.IsComCar,
          emp.Status,
          emp.Location,
          emp.Unit,
          emp.ReportTo,
          emp.OT
        };
        int rowAffect = con.Execute("sp_EmploymentInfo_Insert", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }
    public static bool UpadteEmployment(EmpEmploymentModel emp)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          emp.EmpCode,
          emp.CompanyID,
          emp.BusinessNatureID,
          emp.DesignationID,
          emp.JoinDate,
          emp.JobType,
          emp.EmpGradeID,
          emp.JobDescription,
          emp.JobLocation,
          emp.ProjectID,
          emp.DepartmentID,
          emp.ConfirmationDate,
          emp.ConfirmationDueDate,
          emp.CardNo,
          emp.Experience,
          emp.Location,
          emp.Unit,
          emp.ReportTo,
          emp.OT
        };
        int rowAffect = con.Execute("sp_EmploymentInfo_Update", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }

    //Additional Duty Info
    public static bool SaveAdditionalDuty(EmpAdditionalDutyModel eAD)
    {
      using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
      {
        object paramObj = new
        {
          eAD.ID,
          eAD.EmpCode,
          eAD.PayType,
          eAD.Department,
          eAD.Designation,
          eAD.SchoolorOffice,
          eAD.Responsibilities,
          eAD.NoticeIssuedDate,
          eAD.EffFromDate,
          eAD.EffToDate,
          eAD.Duration,
          eAD.Amount,
          eAD.Remark,
          eAD.CompanyID,
          eAD.UserID,
          eAD.Msg,
          eAD.pOptions
        };
        int rowAffect = con.Execute("sp_AdditionalDuties_New", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }
    public static bool EmpTransfer(EmpTransferModel et)
    {
      using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
      {
        object paramObj = new
        {
          et.EmpCode,
          et.PreCompanyID,
          et.PreDepartmentID,
          et.PreProjectID,
          et.PreDesignationID,
          et.PreDivisionID,
          et.PreBranchID,
          et.PreUnit,
          et.PreLocation,
          et.PreGrade,
          et.PrePayscaleGrade,
          et.PasCompanyID,
          et.PasDepartmentID,
          et.PasProjectID,
          et.PasDesignationID,
          et.PasDivisionID,
          et.PasBranchID,
          et.PasUnit,
          et.PasLocation,
          et.PasGrade,
          et.PasPayscaleGrade,
          et.Note,
          et.TransferDate,
          et.TPType,
          et.CompanyID,
          et.jobresponsibilities
        };
        int rowAffect = con.Execute("sp_EmpTransfer_Save", param: paramObj, commandType: CommandType.StoredProcedure);
        return rowAffect > 0;
      }
    }

    //Report
    public static EmployeeVM GetEmpDetails(string empCode, int companyId)
    {
      using (var con = new SqlConnection(Connection.ConnectionString()))
      {
        var paramObj = new
        {
          EmpCode = empCode,
          CompanyID = companyId
        };
        var employee = con.QuerySingle<EmployeeVM>("sp_getEmpDetaailsInfoForReport", param: paramObj, commandType: CommandType.StoredProcedure);
        return employee;
      }
    }

  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMS.DbContext.SystemSetup;

namespace HRMS.Controllers.SystemSetup
{
    public class BasicEntryController : ApiController
    {
    [HttpGet]
    [Route("api/setup/basic/bank/get")]
    public IHttpActionResult GetBank()
    {
      var result = BasicEntry.GetBank();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/department/get")]
    public IHttpActionResult GetDepartment()
    {
      var result = BasicEntry.GetDepartment();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/departmentgl/get")]
    public IHttpActionResult GetDepartmentGL()
    {
      var result = BasicEntry.GetDepartmentGL();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/section/get")]
    public IHttpActionResult GetSection()
    {
      var result = BasicEntry.GetSection();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/location/get")]
    public IHttpActionResult GetLocation()
    {
      var result = BasicEntry.GetLocation();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/country/get")]
    public IHttpActionResult GetCountry()
    {
      var result = BasicEntry.GetCountry();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/nationality/get")]
    public IHttpActionResult GetNationality()
    {
      var result = BasicEntry.GetNationality();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/gender/get")]
    public IHttpActionResult GetGender()
    {
      var result = BasicEntry.GetGender();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/religion/get")]
    public IHttpActionResult GetReligion()
    {
      var result = BasicEntry.GetReligion();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/blood/get")]
    public IHttpActionResult GetBloodGroup()
    {
      var result = BasicEntry.GetBloodGroup();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/education/get")]
    public IHttpActionResult GetEducation()
    {
      var result = BasicEntry.GetEducation();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/edu/board/get")]
    public IHttpActionResult GetEducationBoard()
    {
      var result = BasicEntry.GetEducationBoard();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/institute/get")]
    public IHttpActionResult GetInstitute()
    {
      var result = BasicEntry.GetInstitute();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/result/get")]
    public IHttpActionResult GetResult()
    {
      var result = BasicEntry.GetResult();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/training/type/get")]
    public IHttpActionResult GetTrainingType()
    {
      var result = BasicEntry.GetTrainingType();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/training/country/get")]
    public IHttpActionResult GetTrainingCountry()
    {
      var result = BasicEntry.GetTrainingCountry();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/training/institute/get")]
    public IHttpActionResult GetTrainingInstitute()
    {
      var result = BasicEntry.GetTrainingInstitute();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/training/nature/get")]
    public IHttpActionResult GetTrainingNature()
    {
      var result = BasicEntry.GetTrainingNature();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/training/sponsor/get")]
    public IHttpActionResult GetTrainingSponsorBy()
    {
      var result = BasicEntry.GetTrainingSponserBy();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/project/get")]
    public IHttpActionResult GetProject()
    {
      var result = BasicEntry.GetProject();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/occupation/get")]
    public IHttpActionResult GetOccupation()
    {
      var result = BasicEntry.GetOccupation();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/experience/type/get")]
    public IHttpActionResult GetExperienceType()
    {
      var result = BasicEntry.GetExperienceType();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/punishment/get")]
    public IHttpActionResult GetPunishment()
    {
      var result = BasicEntry.GetPunishment();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/branch/get")]
    public IHttpActionResult GetBranch()
    {
      var result = BasicEntry.GetBranch();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/unit/get")]
    public IHttpActionResult GetUnit()
    {
      var result = BasicEntry.GetUnit();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/signatory/get")]
    public IHttpActionResult GetSignatory()
    {
      var result = BasicEntry.GetSignatory();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/misconduct/get")]
    public IHttpActionResult GetMisconduct()
    {
      var result = BasicEntry.GetMisconduct();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/prefix/get")]
    public IHttpActionResult GetPrefix()
    {
      var result = BasicEntry.GetPrefix();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/suffix/get")]
    public IHttpActionResult GetSuffix()
    {
      var result = BasicEntry.GetSuffix();
      return Ok(result);
    }
    [HttpGet]
    [Route("api/setup/basic/publication/type/get")]
    public IHttpActionResult GetPublicationType()
    {
      var result = BasicEntry.GetPublicationType();
      return Ok(result);
    }
  }
}


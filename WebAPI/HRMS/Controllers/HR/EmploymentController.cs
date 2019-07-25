using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using HRMS.DbContext.HR;
using HRMS.ViewModels;

namespace HRMS.Controllers.HR
{
  public class EmploymentController : ApiController
  {
    [HttpGet]
    [Route("api/hr/employment/get/empCode/{empCode}/companyId/{companyID}")]
    public IHttpActionResult GetEmployment(string empCode, int companyID)
    {
      Response response = new Response("api / hr / employment / get / empCode /" + empCode + " / companyId /" + companyID);
      try
      {
        var result = Employment.GetEmployment(empCode, companyID);
        if (result != null)
        {
          response.Status = true;
          response.Result = result;
        }
        else
        {
          response.Status = false;
          response.Result = "No data found";
        }
        return Ok(response);
      }
      catch (Exception err)
      {
        response.Status = false;
        response.Result = err.Message;
        return Ok(response);
      }


    }
  }
}

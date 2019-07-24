using HRMS.DbContext;
using HRMS.Models.Employee;
using HRMS.ViewModels;
using HRMS.ViewModels.HR.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRMS.Controllers.HR
{
  public class EmployeeController : ApiController
  {
    [HttpPost]
    [Route("api/employee/genInfo/save")]
    public IHttpActionResult SaveGenInfo(EmpGenInfoModel empGenInfo)
    {
      Response response = new Response("/employee/genInfo/save");
      try
      {
        if (empGenInfo.id == 0)
        {
          response.Status = Employee.SaveEmpGenInfo(empGenInfo);
          if (response.Status)
          {
            response.Result = "Saved successfully!";
          }
          else
          {
            response.Result = "Failed to save!";
          }
        }
        else
        {
          response.Status = Employee.UpdateEmpGenInfo(empGenInfo);
          if (response.Status)
          {
            response.Result = "Updated successfully!";
          }
          else
          {
            response.Result = "Failed to update!";
          }
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

    [HttpGet]
    [Route("api/employee/genInfo/get/gradeVal/{gradeVal}/compId/{compId}/empCode/{empCode}")]
    public IHttpActionResult GetGenInfo(int gradeVal, int compId, string empCode)
    {
      Response response = new Response("/employee/genInfo/get/gradeVal/"+gradeVal+"/compId/"+compId+"/empCode/"+empCode);
      try
      {
        EmpGenInfoModel employee = Employee.GetEmpGenInfo(gradeVal, compId, empCode);
        if (employee != null)
        {
          response.Status = true;
          response.Result = employee;
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

    [HttpGet]
    [Route("api/employee/familyInfo/get/compId/{companyId}/empCode/{empCode}")]
    public IHttpActionResult GetFamilyInfo(int companyId, string empCode)
    {
      Response response = new Response("api/employee/familyInfo/get/compId/" + companyId + "/empCode/" + empCode);
      try
      {
        var family = Employee.GetEmpFamilyInfo(companyId, empCode);
        if (family.Count > 0)
        {
          response.Status = true;
          response.Result = family;
        }
        else
        {
          response.Status = false;
          response.Result = "No data found";
        }
        return Ok(response);
      }
      catch(Exception err)
      {
        response.Status = false;
        response.Result = err.Message;
        return Ok(response);
      }
    }

    [HttpGet]
    [Route("api/employee/familyMember/get/personId/{personId}")]
    public IHttpActionResult GetFamilyMember(int personId)
    {
      Response response = new Response("/employee/familyMember/get/personId/" + personId);
      try
      {
        EmpFamilyInfoModel person = Employee.GetFamilyMember(personId);
        if (person != null)
        {
          response.Status = true;
          response.Result = person;
        }
        else
        {
          response.Status = false;
          response.Result = "Member Not found";
        }
        return Ok(response);
      }
      catch(Exception err)
      {
        response.Status = false;
        response.Result = err.Message;
        return Ok(response);
      }
    }

  }
}

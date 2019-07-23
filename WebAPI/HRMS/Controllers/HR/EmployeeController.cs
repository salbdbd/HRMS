using HRMS.DbContext;
using HRMS.Models.Employee;
using HRMS.ViewModels;
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
        [Route("api/employee/genInfo/get/empCode/{empCode}/compId/{compId}")]
        public IHttpActionResult GetGenInfo(string empCode, int compId)
        {
            Response response = new Response("/employee/genInfo/get/empCode/" + empCode + "/compId/" + compId);
            try
            {
                EmpGenInfoModel employee = Employee.GetEmpGenInfo(empCode, compId);
                if (employee!= null)
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
            catch(Exception err)
            {
                response.Status = false;
                response.Result = err.Message;
                return Ok(response);
            }
        }
    }
}

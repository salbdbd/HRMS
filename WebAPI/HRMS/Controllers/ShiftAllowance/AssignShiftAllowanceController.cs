using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMS.DbContext.ShiftAllowance;
using HRMS.Models.ShiftAllowance;
using HRMS.ViewModels;

namespace HRMS.Controllers.ShiftAllowance
{
    public class AssignShiftAllowanceController : ApiController
    {
        [HttpPost]
        [Route("api/shiftallowance/assignshiftallowance/save")]
        public IHttpActionResult Save(AssignShiftAllowanceModel assignShift)
        {
            Response response = new Response("/shiftallowance/assignshiftallowance/save");
            try
            {

                bool result = AssignShiftAllowance.Save(assignShift);
                if (result)
                {
                    response.Status = true;
                    response.Result = "Successfully Save";
                    return Ok(result);
                }
                else
                {
                    response.Status = false;
                    response.Result = "Fail To Save";
                    return Ok(result);
                }
            }

            catch (Exception err)
            {
                response.Status = false;
                response.Result = "Fail To Save";
                return Ok(response);
            }
        }
        [HttpPost]
        [Route("api/shiftallowance/assignshiftallowance/update")]
        public IHttpActionResult Update(AssignShiftAllowanceModel assignShift)
        {
            Response response = new Response("/shiftallowance/assignshiftallowance/update");
            try
            {

                bool result = AssignShiftAllowance.Update(assignShift);
                if (result)
                {
                    response.Status = true;
                    response.Result = "Successfully Update";
                    return Ok(result);
                }
                else
                {
                    response.Status = false;
                    response.Result = "Fail To Update";
                    return Ok(result);
                }
            }

            catch (Exception err)
            {
                response.Status = false;
                response.Result = "Fail To Update";
                return Ok(response);
            }
        }

        [HttpGet]
        [Route("api/shiftallowance/assignshiftallowance/getall")]
        public IHttpActionResult GetAll()
        {
            var result = AssignShiftAllowance.GetAll();
            return Ok( result);
        }
        [HttpGet]
        [Route("api/shiftallowance/assignshiftallowance/getbyid")]
        public IHttpActionResult GetById(int id)
        {
            var result = AssignShiftAllowance.GetById(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("api/shiftallowance/assignshiftallowance/delete")]
        public IHttpActionResult Delete(int id)
        {
            var result = AssignShiftAllowance.Delete(id);
            return Ok(result);
        }
    }
}
    


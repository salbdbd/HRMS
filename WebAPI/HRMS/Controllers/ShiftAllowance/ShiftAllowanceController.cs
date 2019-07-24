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
    public class ShiftAllowanceController : ApiController
    {
        [HttpPost]
        [Route("api/shiftallowance/amountsetup/saveupdate")]
        public IHttpActionResult SaveUpdate(ShiftAmountSetupModel amountsetup)
        {
            Response response=new Response("/shiftallowance/amountsetup/saveupdate");
            try
            {
                if (amountsetup.ID == 0)
                {
                    bool result = ShiftAmountSetup.Saveupdate(amountsetup);
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
                else
                {
                    bool result = ShiftAmountSetup.Saveupdate(amountsetup);
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
            }
            catch (Exception err)
            {
                response.Status = false;
                response.Result = "Fail To Save";
                return Ok(response);
            }
        }

        [HttpGet]
        [Route("api/shiftallowance/amountsetup/getall")]
        public IHttpActionResult GetAll()
        {
            var result = ShiftAmountSetup.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("api/shiftallowance/amountsetup/getbyid")]
        public IHttpActionResult GetById(int id)
        {
            var result = ShiftAmountSetup.GetById(id);
            return Ok(result);
        }

        [HttpDelete]
        [Route("api/shiftallowance/amountsetup/delete")]
        public IHttpActionResult Delete(int id)
        {
            var result = ShiftAmountSetup.Delete(id);
            return Ok(result);
        }
    }
}

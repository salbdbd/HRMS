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
    public class ShiftAllowanceAutoController : ApiController
    {
        [HttpPost]
        [Route("api/shiftallowance/auto/saveupdate")]
        public IHttpActionResult SaveUpdate(AutoMenualModel autoMenual)
        {
            Response response = new Response("/shiftallowance/amountsetup/saveupdate");
            try
            {
                if (autoMenual.ID == 0)
                {
                    bool result = ShiftAllowanceAuto.SaveUpdate(autoMenual);
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
                    bool result = ShiftAllowanceAuto.SaveUpdate(autoMenual);
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
        [Route("api/shiftallowance/auto/getall")]
        public IHttpActionResult GetAll()
        {
            var result = ShiftAllowanceAuto.GetAll();
            return Ok(result);
        }
        [HttpGet]
        [Route("api/shiftallowance/auto/getbyid")]
        public IHttpActionResult GetById(int id)
        {
            var result = ShiftAllowanceAuto.GetById(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("api/shiftallowance/auto/delete")]
        public IHttpActionResult Delete(int id)
        {
            var result = ShiftAllowanceAuto.Delete(id);
            return Ok(result);
        }
    }
}

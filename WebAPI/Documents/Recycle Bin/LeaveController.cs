using HRMS.DbContext;
using HRMS.Models.Leave;
using HRMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRMS.Controllers
{
    public class LeaveController : ApiController
    {
        [HttpPost]
        [Route("api/leave/type/new")]
        public IHttpActionResult SaveLeaveType(LeaveTypeModel leaveType)
        {
            Response response = new Response("api/leave/type/new");
            try
            {
                bool isSuccess = Leave.SaveLeaveType(leaveType);
                if (isSuccess)
                {
                    response.Status = true;
                    response.Result = "New Leave type added successfully!";
                    return Ok(response);
                }
                else
                {
                    response.Status = false;
                    response.Result = "Failed to add new leave type!";
                    return Ok(response);
                }
            }
            catch (Exception err)
            {
                response.Status = false;
                response.Result = err.Message;
                return Ok(response);
            }
        }

        [HttpPost]
        [Route("api/leave/apply")]
        public IHttpActionResult Apply(LeaveApplyModel leaveApply)
        {
            Response response = new Response("api/leave/apply");
            try
            {
                bool isSuccess = Leave.Apply(leaveApply);
                if (isSuccess)
                {
                    response.Status = true;
                    response.Result = "Leave application sent successfully!";
                    return Ok(response);
                }
                else
                {
                    response.Status = false;
                    response.Result = "Failed to sent leave application successfully!";
                    return Ok(response);
                }
            }
            catch (Exception err)
            {
                response.Status = false;
                response.Result = err.Message;
                return Ok(response);
            }
        }

        [HttpPost]
        [Route("api/leave/entry/manual")]
        public IHttpActionResult ManualEntry(List<LeaveApplyModel> manualLeave)
        {
            Response response = new Response("/leave/entry/manual");
            bool isSuccess = Leave.ManualEntry(manualLeave);
            if (isSuccess)
            {
                response.Status = true;
                response.Result = "Saved Successfully!";
                return Ok(response);
            }
            else
            {
                response.Status = false;
                response.Result = "Failed to manual setup!";
                return Ok(response);
            }
        }

        [HttpPost]
        [Route("api/leave/entry/update")]
        public IHttpActionResult UpdateLeaveInfo(List<LeaveApplyModel> leaveInfoList)
        {
            Response response = new Response("/leave/entry/update");
            try
            {
                bool isSuccess = Leave.UpdateLeaveInfo(leaveInfoList);
                if (isSuccess)
                {
                    response.Status = true;
                    response.Result = "Updated successfully!";
                    return Ok(response);
                }
                else
                {
                    response.Status = false;
                    response.Result = "Failed to update";
                    return Ok(response);
                }
            }
            catch (Exception err)
            {
                response.Status = false;
                response.Result = err.Message;
                return Ok(response);
            }

        }

        [HttpPost]
        [Route("api/leave/openingBalence")]
        public IHttpActionResult OpeningBalence(LeaveBalenceModel leaveBalence)
        {
            Response response = new Response("/leave/openingBalence");
            try
            {
                bool isSuccess = Leave.OpeningBalenceInsert(leaveBalence);
                if (isSuccess)
                {
                    response.Status = true;
                    response.Result = "Leave Opening Balence Inserted";
                    return Ok(response);
                }
                else
                {
                    response.Status = false;
                    response.Result = "Failed to Insert leave opening balence";
                    return Ok(response);
                }
            }
            catch (Exception err)
            {
                response.Status = false;
                response.Result = err.Message;
                return Ok(response);
            }
        }

        [HttpPost]
        [Route("api/leave/carryForward")]
        public IHttpActionResult CarryForward(LeaveBalenceModel leaveBalence)
        {
            Response response = new Response("/leave/carryForward");
            try
            {
                bool isSuccess = Leave.CarryForward(leaveBalence);
                if (isSuccess)
                {
                    response.Status = true;
                    response.Result = "Leave Carry forwarded successfull!";
                    return Ok(response);
                }
                else
                {
                    response.Status = false;
                    response.Result = "Failed to Carry Forward";
                    return Ok(response);
                }
            }
            catch (Exception err)
            {
                response.Status = false;
                response.Result = err.Message;
                return Ok(response);
            }
        }

        [HttpPost]
        [Route("api/leave/encashmentDay")]
        public IHttpActionResult EncashmentDayInsert(LeaveBalenceModel leaveBalence)
        {
            Response response = new Response("/leave/encashmentday");
            try
            {
                bool isSuccess = Leave.EncashmentDayInsert(leaveBalence);
                if (isSuccess)
                {
                    response.Status = true;
                    response.Result = "Inserted successfully!";
                    return Ok(response);
                }
                else
                {
                    response.Status = false;
                    response.Result = "Failed to Insert Encashment day!";
                    return Ok(response);
                }
            }
            catch(Exception err)
            {
                response.Status = false;
                response.Result = err.Message;
                return Ok(response);
            }
        }

       [HttpPost]
       [Route("api/leave/substituteDay")]
       public IHttpActionResult SubstituteLeaveDay(LeaveBalenceModel leaveBalence)
        {
            Response response = new Response("/leave/substituteDay");
            try
            {
                response.Status = Leave.SubstituteLeaveDay(leaveBalence);
                if (response.Status)
                {
                    response.Result = "Substitute Day inserted successfully!";
                    return Ok(response);
                }
                else
                {
                    response.Result = "Failed to insert Substitute Day";
                    return Ok(response);
                }
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

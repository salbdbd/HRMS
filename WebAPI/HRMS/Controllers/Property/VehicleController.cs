using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class VehicleController : ApiController
    {
        [HttpGet]
        [Route("api/property/vehicle/saveUpdate")]
        public IHttpActionResult SaveUpdate(VehicleModel vehicle)
        {
            bool result = DbContext.Vehicle.Saveupdate(vehicle);
            return Ok(result);
        }
        [HttpGet]
        [Route("api/property/vehicle/getall")]
        public IHttpActionResult Categorygetall()
        {
            var result = DbContext.Vehicle.getAll();
            return Ok(result);
        }
        [HttpGet]
        [Route("api/property/vehicle/getbyid/{id}")]
        public IHttpActionResult CategoryGetById(int id)
        {
            var result = DbContext.Vehicle.getById(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("api/property/vehicle/delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var result = DbContext.Vehicle.delete(id);
            return Ok(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class PropertyAssainController : ApiController
    {
        [HttpPost]
        [Route("api/property/assain/saveupdate")]
        public IHttpActionResult Catagorysave(PropertyAssignModel propertyAssign)
        {
            bool result = DbContext.PropertyAssign.saveupdate(propertyAssign);
            return Ok(result);
        }
        [HttpGet]
        [Route("api/property/assain/getall")]
        public IHttpActionResult getall()
        {
            var result = DbContext.PropertyAssign.getAll();
            return Ok(result);
        }
        [HttpGet]
        [Route("api/property/assain/getbyid/{id}")]
        public IHttpActionResult GetById(int id)
        {
            var result = DbContext.PropertyAssign.getById(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("api/property/assain/delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var result = DbContext.PropertyAssign.Delete(id);
            return Ok(result);
        }
    }
}

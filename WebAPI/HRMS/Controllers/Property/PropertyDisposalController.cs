using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class PropertyDisposalController : ApiController
    {
        [HttpPost]
        [Route("api/property/disposal/saveupdate")]
        public IHttpActionResult saveupdate(PropertyDisposalModel prDisposalModel)
        {
            bool result = DbContext.PropertyDisposal.saveUpdate(prDisposalModel);
            return Ok(result);
        }

        [HttpGet]
        [Route("api/property/disposal/getall")]
        public IHttpActionResult getall()
        {
            var result = DbContext.PropertyDisposal.GetAll();
            return Ok(result);
        }
        [HttpGet]
        [Route("api/property/disposal/getbyid/{id}")]
        public IHttpActionResult GetById(int id)
        {
            var result = DbContext.PropertyDisposal.GetById(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("api/property/disposal/delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var result = DbContext.PropertyDisposal.Delete(id);
            return Ok(result);
        }
    }
}

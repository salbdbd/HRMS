using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class AssetAdditionController : ApiController
    {
        [HttpPost]
        [Route("api/property/assetaddition/saveupdate")]
        public IHttpActionResult saveupdate(AssetAdditionModel assetAddition)
        {
            bool result = DbContext.AssetAddition.Saveupdate(assetAddition);
            return Ok(result);
        }
        [HttpGet]
        [Route("api/property/assetaddition/getall")]
        public IHttpActionResult getall()
        {
            var result = DbContext.AssetAddition.getAll();
            return Ok(result);
        }
        [HttpGet]
        [Route("api/property/assetaddition/getbyid/{id}")]
        public IHttpActionResult GetById(int id)
        {
            var result = DbContext.AssetAddition.getById(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("api/property/assetaddition/delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var result = DbContext.AssetAddition.delete(id);
            return Ok(result);
        }
        
    }
}

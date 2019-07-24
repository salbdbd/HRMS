using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class PropertyNameController : ApiController
    {
        [HttpPost]
        [Route("api/property/name/save")]
        public IHttpActionResult NameSave(PropertyNameModel nameModel)
        {
            bool result = DbContext.PropertyName.Save(nameModel);
            return Ok(result);
        }
        [HttpGet]
        [Route("api/property/name/getall")]
        public IHttpActionResult NameGetAll()
        {
            var result = DbContext.PropertyName.GetAll();
            return Ok(result);
        }
        [HttpGet]
        [Route("api/property/name/getbyid/{id}")]
        public IHttpActionResult NameGetById(int id)
        {
            var result = DbContext.PropertyName.GetById(id);
            return Ok(result);
        }
        [HttpGet]
        [Route("api/property/name/getbycategoryid/{id}")]
        public IHttpActionResult NameGetByCategoryId(int id)
        {
            var result = DbContext.PropertyName.GetByCategory(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("api/property/name/delete/{id}")]
        public IHttpActionResult NameDelete(int id)
        {
            var result = DbContext.PropertyName.Delete(id);
            return Ok(result);
        }
        [HttpPut]
        [Route("api/property/name/update")]
        public IHttpActionResult NameUpdate(PropertyNameModel propcat)
        {
            var result = DbContext.PropertyName.Update(propcat);
            return Ok(result);
        }
    }
}

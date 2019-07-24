using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMS.Models;
using HRMS.ViewModels;

namespace HRMS.Controllers
{
    public class PropertyController : ApiController
    {
        [HttpPost]
        [Route("api/property/category/save")]
        public IHttpActionResult Catagorysave(PropertyCatagoryModel catagoryModel)
        {
            Response response = new Response("/property/category/save");
            try
            {
                bool result = DbContext.PropertyCatagory.Save(catagoryModel);
                if (result)
                {
                    response.Status = true;
                    response.Result = "Saved Successfully!";
                    return Ok(response);
                }
                else
                {
                    response.Status = false;
                    response.Result = "Failed to saved!";
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

        [HttpGet]
        [Route("api/property/category/getall")]
        public IHttpActionResult Categorygetall()
        {
            var result = DbContext.PropertyCatagory.GetAll();
            return Ok(result);
        }
        [HttpGet]
        [Route("api/property/category/getbyid/{id}")]
        public IHttpActionResult CategoryGetById(int id)
        {
            var result = DbContext.PropertyCatagory.GetById(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("api/property/category/delete/{id}")]
        public IHttpActionResult CategoryDelete(int id)
        {
            var result = DbContext.PropertyCatagory.Delete(id);
            return Ok(result);
        }
        [HttpPut]
        [Route("api/property/category/update")]
        public IHttpActionResult CategoryUpdate(PropertyCatagoryModel propcat)
        {
            Response response = new Response("/property/category/update");
            try
            {
                var result = DbContext.PropertyCatagory.Update(propcat);
                if (result)
                {
                    response.Status = true;
                    response.Result = "Update Successfully!";
                    return Ok(response);
                }
                else
                {
                    response.Status = false;
                    response.Result = "Failed to Update!";
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
    }

}

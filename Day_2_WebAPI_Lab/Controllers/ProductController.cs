using Day_2_WebAPI_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Day_2_WebAPI_Lab.Controllers
{
    public class ProductController : ApiController
    {
        CompanyEntities context = new CompanyEntities();

        public IHttpActionResult Get()
        {
            return Ok(context.Products.ToList());
        }

        public IHttpActionResult GetOne(int id)
        {
            var prod = context.Products.Find(id);
            return Ok(prod);

        }

    }
}

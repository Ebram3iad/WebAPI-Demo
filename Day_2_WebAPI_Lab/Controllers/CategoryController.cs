using Day_2_WebAPI_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Day_2_WebAPI_Lab.Controllers
{
    public class CategoryController : ApiController
    {
        CompanyEntities context = new CompanyEntities();

        public IHttpActionResult Get()
        {
            return Ok(context.Categories.ToList());
        }

        public IHttpActionResult GetOne(int id)
        {
            var cat = context.Categories.Find(id);
            return Ok(cat);

        }

        public IHttpActionResult Put([FromBody]int id,[FromUri]Category category)
        {
            Category Edited = context.Categories.FirstOrDefault(c=> c.ID==id);
            Edited.Name = category.Name;
            context.SaveChanges();
            return Ok("Updated");
        }

        public IHttpActionResult Post( Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return Ok("Added");
        }
    }
}

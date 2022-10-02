using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ValuesController : ApiController
    {
        private IProductRepository _repository;

        public ValuesController(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> Get()
        {
            return _repository.GetAll();
        }

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        public IHttpActionResult Get(int id)
        {
            var product = _repository.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // GET: api/Person
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public List<Person> Get()
        {
            IPersonDataHandler dataHandler = new PersonDataHandler();
            return dataHandler.Select();
        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Person
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Person/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Person/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

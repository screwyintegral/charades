using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NicoleBCharades
{
    [EnableCors("My Policy")]
    [Route("api/GameController")]
    [ApiController]
    public class GameAPI : ControllerBase
    {
        // GET: api/<GameAPI>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GameAPI>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GameAPI>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GameAPI>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GameAPI>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

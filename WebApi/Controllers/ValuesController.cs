using System.Collections.Generic;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        // GET api/values 
        public IEnumerable<string> Get()
        {   
            return new string[] { "Simple Rest API", "Working!!" };
        }
        [HttpGet("{id}")]
        // GET api/values/5 
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}

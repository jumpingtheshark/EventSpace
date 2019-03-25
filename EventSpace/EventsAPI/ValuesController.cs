using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventsAPI
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        /*
 Request.Headers["XYZComponent"].Count() > 0)

         */
        [HttpGet("A")]
        public string A()

        {

            StringBuilder sb = new StringBuilder();
            foreach (var r in Request.Headers)
            {
                sb.Append(r.Key);
                sb.Append(Environment.NewLine);
                sb.Append(r.Value);
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);



            }

            return sb.ToString();

        }



        [HttpGet("B")]
        public string B()

        {

            StringBuilder sb = new StringBuilder();
            string s = Request.Body.ToString();
            sb.Append(s);

            return sb.ToString();

        }

        // GET: api/<controller>
        [HttpGet("hi")]
        public string Hi(int id)
        {


            return "hello";
          //  return new string[] { "value1", "value2" };
        }


        /*
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    */
    }
}

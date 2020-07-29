using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnlineStoreWebApi.DBA;

namespace OnlineStoreWebApi.Controllers
{
    public class RegistrationController : ApiController
    {
        // GET api/<controller>
        
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }
        [Route("api/login")]
        // POST api/<controller>
        public string Post([FromBody]Login value)
        {
            DBClass db = new DBClass();
            bool isValid=db.Login(value.Email, value.Password);
            if (isValid)
                return "Login Successful";
            return "Wrong Credentials";
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
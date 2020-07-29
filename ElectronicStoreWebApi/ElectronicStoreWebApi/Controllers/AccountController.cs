using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElectronicStoreWebApi.Controllers
{
    public class AccountController : ApiController
    {
        [HttpPost]
        public string Login([FromBody]Login login )
        {
            DBA db = new DBA();
            if(db.Login(login))
            {
                return "Login Successful";
            }
            return "Invalid Credentials";
        }
    }
}

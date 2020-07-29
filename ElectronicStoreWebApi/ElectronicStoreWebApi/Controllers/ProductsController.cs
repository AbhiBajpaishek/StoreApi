using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElectronicStoreWebApi.Controllers
{
    public class ProductsController : ApiController
    {

        [HttpGet]
        public string GetById(int id)
        {
            DBA db = new DBA();
            string query = "select * from tblProducts where ID="+id;
            DataTable dt= db.ReadAll(query);
            var jsonProduct=JsonConvert.SerializeObject(dt);
            return jsonProduct;
        }

        [HttpGet]
        public string GetAll()
        {
            DBA db = new DBA();
            string query = "select * from tblProducts";
            DataTable dt = db.ReadAll(query);
            var jsonProducts = JsonConvert.SerializeObject(dt);
            return jsonProducts;
        }
    }
}

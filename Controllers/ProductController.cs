using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;

namespace Lab_15._3.Controllers
{
    [Route("Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IDbConnection _db;
        public ProductController(IDbConnection db)
        {
            _db = db;
        }

        [HttpGet] //Base Product page
        public List<Product> Products()
        {
            List<Product> products = DAL.ReadProducts(_db);
            return products;
        }

        [HttpGet("Names")] // product/names
        public List<string> GetProductNames()
        {
            List<string> products = DAL.GetProductName(_db);
            return products;
        }

        [HttpPost("NewProduct")] // product/newitem
        [Consumes("application/json")]

        public  long NewProduct([FromBody] Product prod)
        {
            long productID = DAL.Create(_db, prod);
            return productID;
        }    
        

    }
}

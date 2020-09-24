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
    [Route("Category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IDbConnection _db;
        public CategoryController(IDbConnection db)
        {
            _db = db;
        }

        [HttpGet("SearchByDescription/{search}")]
        public List<string> DescriptionSearch(string search)
        {
            List<string> products = DAL.CategorySearch(_db, search);
            return products;
        }

        [HttpGet("SearchByCategory/{search}")]
        public List<string> CategorySearch(string search)
        {
            List<string> products = DAL.DescriptionDetails(_db, search);
            
            if (products.Count > 0)
            {
                return products;
            }
            else
            {
                products.Add("Category does not exist");
            }
            return products;
        }

    }
}

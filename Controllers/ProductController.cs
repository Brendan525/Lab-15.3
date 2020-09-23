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
        private IDbConnection _db;
        public ProductController(IDbConnection db)
        {
            _db = db;
        }
    }
}

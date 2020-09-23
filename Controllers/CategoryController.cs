using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data;

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


    }
}

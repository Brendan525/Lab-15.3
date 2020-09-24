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
    [Route("Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IDbConnection _db;
        public EmployeeController(IDbConnection db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Employees> Employees()
        {
            List<Employees> employees = DAL.ReadEmployees(_db);
            return employees;
        }

        //[HttpGet("All")]
        //public List<Employees> Employees()
        //{
        //    List<Employees> employees = DAL.ReadEmployees(_db);
        //    return employees;
        //}

        [HttpGet("Names")]
        public List<string> GetEmployeesNames()
        {
            List<string> employees = DAL.GetEmployeeName(_db);
            return employees;
        }
    }


}

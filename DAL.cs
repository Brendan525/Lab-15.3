using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Dapper;

namespace Lab_15._3
{
    public class DAL
    {
        public static List<Product> ReadProducts(IDbConnection _db)
        {
            List<Product> products = _db.GetAll<Product>().ToList();
            return products;
        }

        public static List<string> GetProductName(IDbConnection _db)
        {
            string query = $"SELECT ProductName FROM Products";
            return _db.Query<string>(query).ToList(); 
        }

        public static long CreateProduct(IDbConnection _db, Product newProduct)
        {
            long id = _db.Insert<Product>(newProduct);
            return id;
        }

        public static List<string> CategorySearch(IDbConnection _db, string search)
        {
            string query = $"SELECT CategoryName FROM categories WHERE description like '%{search}%'  ";
            return _db.Query<string>(query).ToList();
        }

        public static List<string> DescriptionDetails(IDbConnection _db, string search)
        {
            string query = $"SELECT Description FROM categories WHERE CategoryName = '{search}'  ";
            
            return _db.Query<string>(query).ToList();
        }

        public static List<Employees> ReadEmployees(IDbConnection _db)
        {
            List<Employees> employees = _db.GetAll<Employees>().ToList();
            return employees;
        }

        public static List<string> GetEmployeeName(IDbConnection _db)
        {
            string query = $"SELECT FirstName FROM Employees";
 
            return _db.Query<string>(query).ToList();
        }

        public static long CreateCategory(IDbConnection _db, Category newCategory)
        {
            long id = _db.Insert<Category>(newCategory);
            return id;
        }



        public static void RemoveEmployeeByID(int id, IDbConnection _db)
        {
            string query = $"SELECT * FROM employees WHERE EmployeeID = {id}";
            _db.Delete(new Employees() { EmployeeID = id });
            
        }
    }
}

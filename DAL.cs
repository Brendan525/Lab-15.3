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

        public static Product Create(IDbConnection _db, string productName, bool discontinued)
        {
            Product newProduct = new Product()
            {
                ProductName = productName,
                Discontinued = discontinued
            };

            _db.Insert(newProduct);
            return newProduct;

        }
    }
}

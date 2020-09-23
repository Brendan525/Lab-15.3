using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Lab_15._3
{
    [Table("Product")]
    public class Product
    {

        [Key]
        public long ProductID { get; set; }

        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }  
        public string QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLever { get; set; }
        public bool Discontinued { get; set; }


    }
}

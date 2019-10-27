

using System.Collections.Generic;
using Dapper;
using MySql.Data.MySqlClient;

namespace DemoAwsApp.Helpers
{
    
    public class ProductService
    {

        private readonly MySqlConnection _conn;
        private string _connectionString = "Server=127.0.0.1;Database=TestDb;Uid=root;Pwd=naff;";

        public ProductService()
        {
            _conn = new MySqlConnection(_connectionString);
        }

        public Product GetFirst()
        {
            var sql = "SELECT ProductId, ProductName, ProductStock from Products";
            var result = this._conn.QueryFirst<Product>(sql);
            return result;
        }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
    }
}
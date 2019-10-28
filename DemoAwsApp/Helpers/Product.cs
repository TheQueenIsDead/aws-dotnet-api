

using System;
using System.Collections.Generic;
using Dapper;
using MySql.Data.MySqlClient;

namespace DemoAwsApp.Helpers
{
    
    public class ProductService
    {

        private readonly MySqlConnection _conn;
        private string _connectionString;

        public ProductService()
        {

            var host = Environment.GetEnvironmentVariable("MYSQL_HOST");
            var database = Environment.GetEnvironmentVariable("MYSQL_DB");
            var user = Environment.GetEnvironmentVariable("MYSQL_USER");
            var password = Environment.GetEnvironmentVariable("MYSQL_PASSWORD");
            _connectionString = $"Server={host};Database={database};Uid={user};Pwd={password};";
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
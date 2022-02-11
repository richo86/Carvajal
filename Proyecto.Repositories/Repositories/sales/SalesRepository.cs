using Dapper;
using Proyecto.Models;
using Proyecto.Repositories.Repositories.authentication;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Repositories.Repositories.sales
{
    public class SalesRepository : ISalesRepository
    {
        private SqlConnectionConf _connectionString;

        public SalesRepository(SqlConnectionConf connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> AddSale(Sales sale)
        {
            var database = dbConnection();

            var query = @"INSERT INTO sales (saleDate, ProductId, Quantity, Price, Type, UserId, ProductName)
                        VALUES (@SaleDate, @productId, @quantity, @price, @type, @userId, @productName)";

            var result = await database.ExecuteAsync(query, new { @SaleDate = sale.saleDate, @productId = sale.ProductId,
                @quantity = sale.Quantity, @price = sale.Price, @type = sale.Type, @userId = sale.UserId, @productName = sale.ProductName });

            return result > 0;
        }

        public async Task<IEnumerable<Sales>> GetSales()
        {
            var database = dbConnection();

            var query = @"SELECT * 
                         FROM sales";

            return await database.QueryAsync<Sales>(query, new { });
        }
    }
}

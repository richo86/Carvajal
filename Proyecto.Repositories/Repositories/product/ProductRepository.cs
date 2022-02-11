using Dapper;
using Proyecto.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Proyecto.Repositories.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private SqlConnectionConf _connectionString;

        public ProductRepository(SqlConnectionConf connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var database = dbConnection();

            var query = @"DELETE products
                        WHERE id = @id";

            var result = await database.ExecuteAsync(query, new { id });

            return result > 0;
        }

        public async Task<IEnumerable<Products>> GetAllProducts()
        {
            var database = dbConnection();

            var query = @"SELECT id, name, category, description, price, imagePath
                        FROM products";

            return await database.QueryAsync<Products>(query, new { });
        }

        public async Task<Products> GetProduct(int id)
        {
            var database = dbConnection();

            var query = @"SELECT *
                        FROM products
                        WHERE id = @Id";

            return await database.QueryFirstOrDefaultAsync<Products>(query, new { Id = id });
        }

        public async Task<bool> InsertProduct(Products product)
        {
            var database = dbConnection();

            var query = @"INSERT INTO products (name, category, description, price, imagePath)
                        VALUES (@name, @category, @description, @price, @imagePath)";

            var result = await database.ExecuteAsync(query, new { product.name, product.category, product.description, product.price, product.imagePath });

            return result > 0;
        }

        public async Task<bool> UpdateProduct(Products product)
        {
            var database = dbConnection();

            var query = @"UPDATE products
                        SET name = @Name, category = @Category, description = @Description, price = @Price, imagePath = @ImagePath
                        WHERE id = @id";

            var result = await database.ExecuteAsync(query, new { Name = product.name, Category = product.category, Description = product.description,
                            Price = product.price, ImagePath = product.imagePath, id = product.id });

            return result > 0;
        }
    }
}

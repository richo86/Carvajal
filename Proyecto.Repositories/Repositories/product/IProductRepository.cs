using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Models;

namespace Proyecto.Repositories.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Products>> GetAllProducts();
        Task<Products> GetProduct(int id);
        Task<bool> InsertProduct(Products product);
        Task<bool> UpdateProduct(Products product);
        Task<bool> DeleteProduct(int id);
    }
}

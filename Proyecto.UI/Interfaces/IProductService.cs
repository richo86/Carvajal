using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.UI.Interfaces
{
    public interface IProductService
    {
        Task<List<Products>> GetAllProducts();
        Task<Products> GetProduct(int id);
        Task SaveProduct(Products product);
        Task DeleteProduct(int id);
    }
}

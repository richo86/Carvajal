using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;
using Proyecto.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proyecto.UI.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task DeleteProduct(int id)
        {
            await _httpClient.DeleteAsync($"api/Product/{id}");
        }

        public async Task<List<Products>> GetAllProducts()
        {
            return await JsonSerializer.DeserializeAsync<List<Products>>(
                await _httpClient.GetStreamAsync($"api/Product"), 
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Products> GetProduct(int id)
        {
            return await JsonSerializer.DeserializeAsync<Products>(
                await _httpClient.GetStreamAsync($"api/Product/{id}"),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task SaveProduct(Products product)
        {
            var json = new StringContent(JsonSerializer.Serialize(product),
                Encoding.UTF8, "application/json");

            if (product.id == 0)
                await _httpClient.PostAsync($"api/Product", json);
            else
                await _httpClient.PutAsync($"api/Product", json);
        }
    }
}

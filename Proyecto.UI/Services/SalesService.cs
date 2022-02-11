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
    public class SalesService : ISalesService
    {
        private readonly HttpClient _httpClient;

        public SalesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Sales>> GetSales()
        {
            return await JsonSerializer.DeserializeAsync<List<Sales>>(
                await _httpClient.GetStreamAsync($"api/Sales"),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<bool> InsertSale(List<Sales> sales)
        {
            var json = new StringContent(JsonSerializer.Serialize(sales),
                Encoding.UTF8, "application/json");

            if (sales.Count != 0)
                await _httpClient.PostAsync($"api/Sales", json);

            return true;
        }
    }
}

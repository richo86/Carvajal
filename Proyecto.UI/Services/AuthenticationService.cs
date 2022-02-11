using Proyecto.Models;
using Proyecto.UI.Interfaces;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proyecto.UI.Services
{
    public class AuthenticationService : IAuthentication
    {
        private readonly HttpClient _httpClient;

        public AuthenticationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> CreateUser(Users user)
        {
            var json = new StringContent(JsonSerializer.Serialize(user),
                Encoding.UTF8, "application/json");

            var result = await _httpClient.PostAsync("api/Authentication", json);

            return result;
        }

        public async Task<UsersViewModel> GetUser(int id)
        {
            var result = await JsonSerializer.DeserializeAsync<UsersViewModel>(
                await _httpClient.GetStreamAsync($"api/Authentication/{id}"),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            
            return result;
        }

        public async Task<UsersViewModel> SignIn(string email, string password)
        {
            try
            {
                //HttpResponseMessage response = await _httpClient.GetAsync($"api/Authentication/{email}/{password}").ConfigureAwait(false);
                //response.EnsureSuccessStatusCode();
                //string responseBody = await response.Content.ReadAsStringAsync();

                return await JsonSerializer.DeserializeAsync<UsersViewModel>(
                await _httpClient.GetStreamAsync($"api/Authentication/{email}/{password}").ConfigureAwait(false),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
            catch(Exception ex)
            {
                var message = ex.Message;
            }
            return new UsersViewModel();
        }

        public async Task<bool> SignOut(int id)
        {
            var result = await _httpClient.GetAsync($"api/authentication/logout/{id}");

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                return true;

            return false;
        }
    }
}

using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Proyecto.UI.Interfaces
{
    public interface IAuthentication
    {
        Task<HttpResponseMessage> CreateUser(Users user);
        Task<UsersViewModel> GetUser(int id);
        Task<UsersViewModel> SignIn(string email, string password);
        Task<bool> SignOut(int id);
    }
}

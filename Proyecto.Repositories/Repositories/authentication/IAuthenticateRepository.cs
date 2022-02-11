using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Repositories.Repositories.authentication
{
    public interface IAuthenticateRepository
    {
        Task<bool> RegisterUser(Users user);
        Task<Users> GetUser(int id);
        Task<Users> SignIn(string email, string password);
        Task<bool> SignOut(int id);
    }
}

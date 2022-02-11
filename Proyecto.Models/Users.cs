using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Models
{
    public class Users
    {
        public long Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Roles role { get; set; }
        public DateTime registerDate { get; set; }
        public DateTime passwordExpiration { get; set; }
        public int signInRetries { get; set; }
        public string lockout { get; set; }
        public DateTime lockoutTime { get; set; }
        public string isLoggedIn { get; set; }

    }
}

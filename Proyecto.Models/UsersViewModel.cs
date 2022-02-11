using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Models
{
    public class UsersViewModel
    {
        public long Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public Roles role { get; set; }
        public string isLoggedIn { get; set; }

    }
}

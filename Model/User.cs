using System;
using System.Collections.Generic;
using System.Text;

namespace Salão_Model.Model
{
    public abstract class User
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public abstract bool Login(List<User> users, string email, string password);
    }
}

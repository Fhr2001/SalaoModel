using System;
using System.Collections.Generic;
using System.Text;

namespace Salão_Model.Model
{
    public class Admin : User
    {
        public Admin(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public override bool Login(List<User> users, string email, string password){
            throw new NotImplementedException();
        }
    }
}

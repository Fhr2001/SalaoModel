using System;
using System.Collections.Generic;
using System.Text;

namespace Salão_Model.Model
{
    class Admin : User
    {
        public Admin(int id, string name, string email, string password)
        {
            ID = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public override bool Login(string email, string password){
            throw NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Salão_Model.Model
{
    class Provider : User
    {
        public List<Service> LicensedServices { get; set; }

        public Provider(string name, string email, string password, string phone)
        {
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
        }
        public override bool Login(string email, string password){
            throw NotImplementedException();
        }
    }
}

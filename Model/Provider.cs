using System;
using System.Collections.Generic;
using System.Text;

namespace Salão_Model.Model
{
    public class Provider : User
    {
        public List<Service> LicensedServices { get; set; }

        public Provider(string name, string email, string password, string phone)
        {
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
            LicensedServices = new List<Service>();
        }

        public override bool Login(List<User> users, string email, string password){
            throw new NotImplementedException();
        }

        public void AddLincensedService(Service service)
        {
            LicensedServices.Add(service);
        }
    }
}

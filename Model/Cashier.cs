using System;
using System.Collections.Generic;
using System.Text;


namespace Salão_Model.Model
{
    class Cashier : User
    {
        public Cashier(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public override bool Login(string email, string password){
            throw new NotImplementedException();
        }

        public void StartPayment(Client client){
            throw new NotImplementedException();
        }

        public void DoPayment(string forma, double price, List<ServiceProvider> servicesProviders){
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;


namespace Salão_Model.Model
{
    class Cashier : User
    {
        public Cashier(int id, string name, string email, string password)
        {
            ID = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public override bool Login(string email, string password){
            throw NotImplementedException();
        }
        public void startPayment(Client client){
            throw NotImplementedException();
        }
        public void doPayment(string forma, double price, List<ServiceProvider> servicesProviders){
            throw NotImplementedException();
        }
    }
}

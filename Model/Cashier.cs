using System;
using System.Collections.Generic;
using System.Text;


namespace Salão_Model.Model
{
    public class Cashier : User
    {
        public Cashier(string name, string email, string password, string phone)
        {
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
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

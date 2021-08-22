using System;
using System.Collections.Generic;
using System.Text;

namespace Salão_Model.Model
{
    class Client : User
    {
        private List<ServiceProvider> ServicesProvided;
        private List<Agenda> Agendas;

        public Client(string name, string email, string password, Location address, string phone)
        {
            Name = name;
            Email = email;
            Password = password;
            Address = address;
            Phone = phone;
            ServicesProvided = new List<ServiceProvider>();
            Agendas = new List<Agenda>();
        }

        public override bool Login(string email, string password){
            throw new NotImplementedException();
        }

        public void AddAgenda(Agenda agenda){
            foreach (Agenda itemAgenda in Agendas)
            {
                if (itemAgenda.DateTime == agenda.DateTime)
                    throw new Exception("Agenda duplicada");
            }
            Agendas.Add(agenda);
        }

        public List<ServiceProvider> GetServiceProvider(DateTime dateTime){
            throw new NotImplementedException();
        }

        public bool ValidateConclusion(Service service){
            throw new NotImplementedException();
        }
    }
}

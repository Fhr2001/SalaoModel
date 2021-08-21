using System;
using System.Collections.Generic;
using System.Text;

namespace Salão_Model.Model
{
    class Client : User
    {
        private List<ServiceProvider> ServicesProvided;
        private List<Agenda> Agendas;

        public Client(int id, string name, string email, string password, Location address, string phone)
        {
            ID = id;
            Name = name;
            Email = email;
            Password = password;
            Address = address;
        }

        public override bool Login(string email, string password){
            throw NotImplementedException();
        }

        public void addAgenda(Agenda agenda){
            foreach (Agenda itemAgenda in Agendas)
            {
                if (itemAgenda.DateTime == agenda.DateTime)
                    throw Exception("Agenda duplicada");
            }
            Agendas.Add(agenda);
        }

        public List<ServiceProvider> getServiceProvider(DateTime dateTime){
            throw NotImplementedException();
        }

        public bool validateConclusion(Service service){
            throw NotImplementedException();
        }
    }
}

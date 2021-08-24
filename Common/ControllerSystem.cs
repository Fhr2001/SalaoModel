using Salão_Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salão_Model.Common
{
    public class ControllerSystem
    {
        private static ControllerSystem controllerSystem;
        private static User currentUser;
        
        private static List<Service> services;
        private static List<User> users;
        private static List<Agenda> agendas;

        private ControllerSystem()
        {
            currentUser = null;
            services = new List<Service>();
            users = new List<User>();
            agendas = new List<Agenda>();
        }

        public static ControllerSystem GetInstance()
        {
            if (controllerSystem == null)
                controllerSystem = new ControllerSystem();
            return controllerSystem;
        }

        public Client RegisterClient(string name, string email, string password, string gender, string phone, Location address)
        {
            var client = new Client(
                name: name, email: email, 
                password: password, phone: phone, gender: gender, address: address);
            users.Add(client);
            return client;
        }

        public User RegisterEmployee(string name, string email, string password, string phone, string user_type="provider")
        {
            User employee;
            if (user_type == "provider")
                employee = new Provider(name, email, password, phone);
            else
                employee = new Cashier(name, email, password, phone);
            
            users.Add(employee);
            
            return employee;
        }

        public Agenda CreateAgenda(Service service, DateTime dateTime, Provider provider)
        {
            Agenda agenda = new Agenda(service, provider, dateTime);
            agendas.Add(agenda);
            return agenda;
        }
    }
}

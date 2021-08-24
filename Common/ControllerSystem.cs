using Salão_Model.Enum;
using Salão_Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salão_Model.Common
{
    public class ControllerSystem
    {
        private static ControllerSystem controllerSystem;
        private static Client currentClient;
        
        private static List<Service> services;
        private static List<User> users;
        private static List<Agenda> agendas;
        private static List<ServiceProvider> serviceProviders;

        private ControllerSystem()
        {
            services = new List<Service>();
            users = new List<User>();
            agendas = new List<Agenda>();
            serviceProviders = new List<ServiceProvider>();
        }

        public static ControllerSystem GetInstance()
        {
            if (controllerSystem == null)
                controllerSystem = new ControllerSystem();
            return controllerSystem;
        }

        public bool ClientLogin(string email, string password)
        {
            return new Client().Login(users, email, password);
        }

        public Client RegisterClient(string name, string email, string password, string gender, string phone, string address)
        {
            var client = new Client(
                name: name, email: email, 
                password: password, phone: phone, gender: gender, address: address);
            users.Add(client);
            return client;
        }

        public Client ReadClient(string email, string password)
        {
            currentClient = Client.GetClient(users, email, password);
            return currentClient;
        }

        public List<Client> ReadListClient()
        {
            return Client.GetClients(users);
        }

        public Client UpdateClient(string name, string email, string password, string gender, string phone, string address)
        {
            int index = GetIndexOfUsers(currentClient);

            currentClient.Update(name, email, password, gender, phone, address);
            users[index] = currentClient;

            return currentClient;
        }

        public void DeleteClient()
        {
            users.Remove(currentClient);
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

            if (!CheckAvailability(agenda))
                return null;

            currentClient = agenda.LinkToClient(currentClient);

            agendas.Add(agenda);
            serviceProviders.Add(agenda.ServiceProvider);
            
            return agenda;
        }

        public Service CreateService(string name, double price)
        {
            var service = new Service(name: name, price: price);
            services.Add(service);
            return service;
        }

        public List<Service> GetServices(ServiceStatus serviceStatus=ServiceStatus.Active)
        {
            return services.FindAll(s => s.Status == serviceStatus);
        }

        public bool CheckAvailability(Agenda agenda)
        {
            return Agenda.CheckAvailability(agendas, agenda);
        }

        public List<Agenda> GetWorkAgenda(Provider provider)
        {
            return Agenda.GetWorkAgenda(agendas, provider);
        }

        public void StartService(Agenda agenda)
        {
            int index = GetIndexOfServiceProviders(agenda.ServiceProvider);

            agenda.StartService();
            serviceProviders[index] = agenda.ServiceProvider;
        }

        public Provider ReadProvider(string email, string password)
        {
            return Provider.GetProvider(users, email, password);
        }

        public List<Provider> ReadListProvider()
        {
            return Provider.GetProviders(users);
        }

        public List<Provider> ReadListProvider(Service service)
        {
            return Provider.GetLicensedProviders(users, service);
        }

        public void AddLincensedService(Provider provider, Service service)
        {
            provider.AddLincensedService(service);
        }

        public void RegisterFinish(Agenda agenda)
        {
            int index = GetIndexOfServiceProviders(agenda.ServiceProvider);

            agenda.FinishService();
            serviceProviders[index] = agenda.ServiceProvider;
        }


        #region Auxiliary Methods
        private int GetIndexOfServiceProviders(ServiceProvider serviceProvider)
        {
            serviceProviders.Find(sp => serviceProvider == sp);
            return serviceProviders.IndexOf(serviceProvider);
        }

        private int GetIndexOfUsers(User user)
        {
            users.Find(u => u == user);
            return users.IndexOf(user);
        }
        #endregion

    }
}

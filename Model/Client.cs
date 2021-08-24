using System;
using System.Collections.Generic;
using System.Text;

namespace Salão_Model.Model
{
    public class Client : User
    {
        public string Address { get; set; }
        private List<ServiceProvider> ServicesProvided;
        private List<Agenda> Agendas;

        public Client()
        {

        }

        public Client(string name, string email, string password, string phone, string gender, string address)
        {
            Name = name;
            Email = email;
            Password = password;
            Address = address;
            Phone = phone;
            Gender = gender;
            ServicesProvided = new List<ServiceProvider>();
            Agendas = new List<Agenda>();
        }

        public override bool Login(List<User> users, string email, string password){
            return GetClient(users, email, password) != null;
        }

        public void Update(string email, string password, string gender, string phone, string address)
        {
            Email = email ?? Email;
            Password = password ?? Password;
            Gender = gender ?? Gender;
            Phone = phone ?? Phone;
            Address = address ?? Address;
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
            if (dateTime == null)
                return ServicesProvided;
            return ServiceProvider.GetFiltered(dateTime);
        }

        public bool ValidateConclusion(Service service){
            throw new NotImplementedException();
        }

        #region Static Methods
        public static Client GetClient(List<User> users, string email, string password)
        {
            return (Client)users.FindLast(u => u.Email == email && u.Password == password && u.GetType() == typeof(Client));
        }
        #endregion
    }
}

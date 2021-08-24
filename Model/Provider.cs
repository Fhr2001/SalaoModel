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

        #region Static Methods
        public static Provider GetProvider(List<User> users, string email, string password)
        {
            return (Provider)users.FindLast(u => u.Email == email && u.Password == password && u.GetType() == typeof(Provider));
        }

        public static List<Provider> GetProviders(List<User> users)
        {
            var objs = users.FindAll(u => u.GetType() == typeof(Provider));
            var providers = new List<Provider>();
            foreach (var obj in objs)
            {
                providers.Add(obj as Provider);
            }

            return providers;
        }

        public static List<Provider> GetLicensedProviders(List<User> users, Service service)
        {
            var objs = users.FindAll(u => u.GetType() == typeof(Provider));
            var providers = new List<Provider>();
            foreach (var obj in objs)
            {
                var provider = obj as Provider;
                if (provider.LicensedServices.Contains(service))
                    providers.Add(provider);
            }

            return providers;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Salão_Model.Enum;

namespace Salão_Model.Model
{
    public class ServiceProvider
    {
        public Service Service { get; private set; }
        public Provider Provider { get; private set; }
        public ServiceProviderStatus Status { get; set; }

        public ServiceProvider(Service service, Provider provider)
        {
            Service = service;
            Provider = provider;
            Status = ServiceProviderStatus.NotStarted;
        }

        public void Start(){
            Status = ServiceProviderStatus.InProgress;
        }

        public void Finish(){
            Status = ServiceProviderStatus.Concluded;
        }

        #region Static Methods
        public static List<Agenda> GetAgendas(DateTime dateTime)
        {
            return new List<Agenda>();
        }

        public static List<ServiceProvider> GetFiltered(DateTime dateTime)
        {
            return new List<ServiceProvider>();
        }
        #endregion

    }
}

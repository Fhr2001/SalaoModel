using System;
using System.Collections.Generic;
using System.Text;

namespace Salão_Model.Model
{
    public class Agenda
    {
        public DateTime DateTime { get; private set; }
        public ServiceProvider ServiceProvider { get; private set; }

        public Agenda(Service service, Provider provider, DateTime dateTime)
        {
            ServiceProvider = new ServiceProvider(service, provider);
            DateTime = dateTime;
        }

        public void StartService()
        {
            ServiceProvider.Start();
        }

        public void FinishService()
        {
            ServiceProvider.Finish();
        }

        public Client LinkToClient(Client client)
        {
            client.AddAgenda(this);
            return client;
        }

        #region Static Methods
        public static bool CheckAvailability(List<Agenda> agendas, Agenda agenda)
        {
            return !agendas.Exists(
                ag => ag.ServiceProvider.Provider == agenda.ServiceProvider.Provider 
                && ag.DateTime == agenda.DateTime);
        }

        public static List<Agenda> GetWorkAgenda(List<Agenda> agendas, Provider provider)
        {
            return agendas.FindAll(ag => ag.ServiceProvider.Provider == provider);
        }
        #endregion
    }
}

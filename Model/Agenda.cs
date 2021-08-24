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
    }
}

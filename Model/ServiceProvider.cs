using System;
using System.Collections.Generic;
using System.Text;
using Salão_Model.Enum;

namespace Salão_Model.Model
{
    class ServiceProvider
    {
        public Service Service { get; private set; }
        public Provider Provider { get; private set; }
        public ServiceProviderStatus Status { get; set; }

        public void start(){
            Status = ServiceProviderStatus.InProgress;
        }
        public void finish(){
            Status = ServiceProviderStatus.Concluded;
        }
    }
}

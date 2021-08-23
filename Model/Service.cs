using System;
using System.Collections.Generic;
using System.Text;
using Salão_Model.Enum;

namespace Salão_Model.Model
{
    public class Service
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ServiceStatus Status { get; set; }

        public Service()
        {
            
        }

    }
}

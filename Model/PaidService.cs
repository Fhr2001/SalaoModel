using System;
using System.Collections.Generic;
using System.Text;

namespace Salão_Model.Model
{
    class PaidService
    {
        public int ID { get; set; }
        public Payment Payment { get; set; }
        public Service Service { get; set; }
    }
}

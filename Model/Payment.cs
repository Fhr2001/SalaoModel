using System;
using System.Collections.Generic;
using System.Text;

namespace Salão_Model.Model
{
    class Payment
    {
        public int ID { get; set; }
        public Cashier PaidBy { get; set; }
        
    }
}

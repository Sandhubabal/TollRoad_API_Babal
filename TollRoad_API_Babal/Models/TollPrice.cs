﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TollRoad_API_Babal.Models
{
    public class TollPrice
    {
        public int ID { get; set; }
        public decimal Charges { get; set; }
        public List<Customer> Customers { get; set; }
    }
}

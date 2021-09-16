﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TollRoad_API_Babal.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string VehicleNo { get; set; }
        public int VehicleID { get; set; }
        public int TollPriceID { get; set; }
        public Vehicle Vehicle { get; set; }
        public TollPrice TollPrice { get; set; }
    }
}
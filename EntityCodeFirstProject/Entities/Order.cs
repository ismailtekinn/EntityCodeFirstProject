﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCodeFirstProject.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string OrderDate { get; set; }
        public User Customer { get; set; }
    }
}
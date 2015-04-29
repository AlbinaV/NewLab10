using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Lab10.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Address { get; set; }
    }
}
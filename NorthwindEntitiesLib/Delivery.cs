using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindEntitiesLib
{    
    public class Delivery
    {
        public int DeliveryID { get; set; }
        public int DeliveryCurrentNumber { get; set; } = 0;
        public string DeliveryProduct { get; set; }        
        public string DeliveryProductPrice { get; set; }
        public int DeliveryProductQuantity { get; set; }
    }
}

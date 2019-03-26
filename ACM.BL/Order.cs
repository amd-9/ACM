using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        public Order() : this(0)
        {
            
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int ShippingAddressId { get; set; }  
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        /// Validates the order data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

    }
}

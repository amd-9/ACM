using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
            
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>
        /// Retrive one order
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Order Retrive(int productId)
        {
            // Code that retrieves the defined order

            return new Order();
        }

        /// <summary>
        /// Saves the current order
        /// </summary>
        public bool Save()
        {
            //Code that saves the defined order

            return true;
        }

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

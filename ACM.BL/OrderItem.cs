using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ACM.BL
{
    public class OrderItem: EntityBase
    {
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrive one order item
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public OrderItem Retrive(int productId)
        {
            // Code that retrieves the defined order item

            return new OrderItem();
        }

        /// <summary>
        /// Saves the current order item
        /// </summary>
        public bool Save()
        {
            //Code that saves the defined order item

            return true;
        }

        /// <summary>
        /// Validates the order item data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}

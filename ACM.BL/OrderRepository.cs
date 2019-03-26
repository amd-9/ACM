﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year,
                    4,14,10,00,00,new TimeSpan(7,0,0));
            }

            return order;
        }

        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Order customer)
        {
            return true;
        }
    }
}

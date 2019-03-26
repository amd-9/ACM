using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
            
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }

                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        /// <summary>
        /// Validates the customer data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrive one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrive(int customerId)
        {
            // Code that retrieves the defined customer

            return new Customer();
        }

        /// <summary>
        /// Retrieve all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrive()
        {
            // Code that retrieves the defined customer

            return new List<Customer>();
        }
        
        /// <summary>
        /// Saves the current customer
        /// </summary>
        public bool Save()
        {
            //Code that saves the defined customer

            return true;
        }

    }
}

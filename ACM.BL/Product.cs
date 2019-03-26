using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
                
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Retrive one product
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Product Retrive(int productId)
        {
            // Code that retrieves the defined product

            return new Product();
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        public bool Save()
        {
            //Code that saves the defined product

            return true;
        }

        /// <summary>
        /// Validates the product data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}

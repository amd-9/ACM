using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BL.Tests
{
    public class ProductRepositoryShould
    {
        [Fact]
        public void RetrieveProductById()
        {
            //-- Arrange
            var productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Very tasty sunflowers!",
                CurrentPrice = 15.96M
            };

            //-- Act
            var actual = productRepository.Retrieve(2);

            //-- Assert
            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(expected.ProductDescription, actual.ProductDescription);
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
        }

        [Fact]
        public void SaveValidProduct()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription =  "Very tasty hot dogs",
                ProductName = "Hot dogs",
                HasChanges = true
                 
            };
            //-- Act
            var actual = productRepository.Save(updateProduct);

            //-- Assert
            Assert.True(actual);
        }

        [Fact]
        public void DoNotSaveInvalidProduct()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Very tasty hot dogs",
                ProductName = "Hot dogs",
                HasChanges = true

            };
            //-- Act
            var actual = productRepository.Save(updateProduct);

            //-- Assert
            Assert.False(actual);
        }
    }
}

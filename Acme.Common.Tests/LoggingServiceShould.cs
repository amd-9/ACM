using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Acme.Common.Tests
{
    public class LoggingServiceShould
    {
        [Fact]
        public void WriteToFile()
        {
            //Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };

            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };

            changedItems.Add(product);
            //Act
            LogginService.WriteToFile(changedItems);

            //Assert
        }
    }
}

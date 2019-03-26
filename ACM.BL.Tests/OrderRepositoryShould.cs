using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BL.Tests
{
    public class OrderRepositoryShould
    {
        [Fact]
        public void RetrieveOrderById()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();

            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year,
                    4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //-- Act
            var actual = orderRepository.Retrieve(10);

            //-- Assert
            Assert.Equal(expected.OrderDate, actual.OrderDate);
        }
    }
}

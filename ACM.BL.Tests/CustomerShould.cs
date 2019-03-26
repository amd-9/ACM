using System;
using Xunit;

namespace ACM.BL.Tests
{
    public class CustomerShould
    {
        [Fact]
        public void ReturnFullName()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Bilbo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnFullNameWithFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };

            string expected = "Baggins";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnFullNameWithLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };

            string expected = "Bilbo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PassStaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert
            Assert.Equal(3, Customer.InstanceCount);
        }

        [Fact]
        public void ValidateValidCustomer()
        {
            //-- Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = true;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateIvalidCustomer()
        {
            //-- Arrange
            var customer = new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = false;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.Equal(expected, actual);
        }
    }
}

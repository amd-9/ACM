using System;
using Xunit;

namespace Acme.Common.Tests
{
    public class StringHanlderShould
    {
        [Fact]
        public void InsertSpacesToString()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NotInsertSpacesToStringWithExistingSpace()
        {
            //Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

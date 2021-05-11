using System;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Main()
        {

            //arrange
            string actual = "FizzBuzz";

            //act
            double expected = Main();

            //assert
            Assert.Equal(expected, actual);

        }
    }
}

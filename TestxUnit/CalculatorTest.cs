using System;
using consoleApp;
using Xunit;


namespace unitTest
{
    public class CalculatorTest
    {
        [Fact]
        public void TestSum()
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            var mySum=cal.Sum(5,4);           

            //Assert
            Assert.IsType<int>(mySum);
            Assert.Equal(9,mySum);
            Assert.NotEqual(10,mySum);
        }
    }
    
}

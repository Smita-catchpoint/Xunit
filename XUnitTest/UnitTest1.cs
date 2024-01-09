using SimpleConsoleApp;
using Xunit;
namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            int Result = calculator.Add(2, 3);

            //Assert
            Assert.Equal(5, Result);

        }
    }
}
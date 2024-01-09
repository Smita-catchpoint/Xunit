using SimpleConsoleApp;

namespace XUnitTest
{
    public class StringManipulatorTest
    {
        [Theory]
        [MemberData(nameof(StringManipulator.TestData),MemberType = typeof(StringManipulator))]

        public void CanConcatString(string str1,string str2,string ExpectedValue)
        {
            //Arrange
            var stringManipulator = new StringManipulator();
            //Act
            var result = stringManipulator.Concatenate(str1, str2);
            //Assert
            Assert.Equal(ExpectedValue, result);
   

        }
    }
}

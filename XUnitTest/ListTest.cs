
using SimpleConsoleApp;
using Xunit;

namespace XUnitTest
{
   
        public class ListTest
        {
            [Fact]
            public void FilterEvenNumbers_ShouldReturnEvenNumbers()
            {
                // Arrange
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                // Act
                List<int> evenNumbers = ListCollection.FilterEvenNumbers(numbers);

                // Assert
                Assert.Equal(new List<int> { 2, 4, 6, 8, 10 }, evenNumbers);
            }

            [Fact]
            public void FilterEvenNumbers_ShouldReturnEmptyListForOddNumbers()
            {
                // Arrange
                List<int> numbers = new List<int> { 1, 3, 5, 7, 9 };

            // Act
                List<int> evenNumbers = ListCollection.FilterEvenNumbers(numbers);

                // Assert
                Assert.Empty(evenNumbers);
            }

            [Fact]
            public void FilterEvenNumbers_ShouldReturnEmptyListForEmptyInput()
            {
                // Arrange
                List<int> numbers = new List<int>();

                // Act
                List<int> evenNumbers = ListCollection.FilterEvenNumbers(numbers);

                // Assert
                Assert.Empty(evenNumbers);
            }
        }
    }


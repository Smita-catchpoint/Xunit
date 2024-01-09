
//using simpleconsoleapp;


//namespace XUnitTest
//{
//    public class StringLibraryTest
//    {
//        [Fact]
//        public void StartsWithUpper_ValidInput_ReturnsTrue()
//        {
//            // Arrange
//            string input = "Hello";

//            // Act
//            // bool result = input.startswithupper();
//            bool result = StringLibrary.StartsWithUpper(input);

//            // Assert
//            Assert.True(result);
//        }

//        [Fact]
//        public void StartsWithLower_ValidInput_ReturnsTrue()
//        {
//            // Arrange
//            string input = "hello";

//            // Act
//            bool result = StringLibrary.StartsWithLower(input);

//            // Assert
//            Assert.True(result);
//        }

//        [Fact]
//        public void StartsWithUpper_EmptyInput_ReturnsFalse()
//        {
//            // Arrange
//            string input = string.Empty;

//            // Act
//            bool result = StringLibrary.StartsWithUpper(input);

//            // Assert
//            Assert.False(result);
//        }

//        [Fact]
//        public void StartsWithLower_NullInput_ReturnsFalse()
//        {
//            // Arrange
//            string input = null;

//            // Act
//            bool result = StringLibrary.StartsWithLower(input);
//            // Assert
//            Assert.False(result);
//        }

//        [Fact]
//        public void HasEmbeddedSpaces_InputWithSpaces_ReturnsTrue()
//        {
//            // Arrange
//            string input = "Contains Spaces";

//            // Act
//            bool result = StringLibrary.HasEmbeddedSpaces(input);

//            // Assert
//            Assert.True(result);
//        }

//        [Fact]
//        public void HasEmbeddedSpaces_NoSpaces_ReturnsFalse()
//        {
//            // Arrange
//            string input = "NoSpaces";

//            // Act
//            bool result = StringLibrary.HasEmbeddedSpaces(input);

//            // Assert
//            Assert.False(result);
//        }
//    }
//}

using simpleconsoleapp;
namespace XUnitTest
{
    public class StringLibraryTests
    {
        [Fact]
        public void TestStartsWithUpper()
        {
            // Tests that we expect to return true.
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.True(result,
                            $"Expected for '{word}': true; Actual: {result}");
            }
        }

        [Fact]
        public void TestDoesNotStartWithUpper()
        {
            // Tests that we expect to return false.
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                           "1234", ".", ";", " " };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.False(result,
                             $"Expected for '{word}': false; Actual: {result}");
            }
        }
        [Fact]
        public void DirectCallWithNullOrEmpty()
        {
            // Tests that we expect to return false.
            string[] words = { string.Empty, null };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.False(result,
                             $"Expected for '{(word == null ? "<null>" : word)}': " +
                             $"false; Actual: {result}");
            }
        }

        [Fact]
        public void TestHasEmbeddedSpaces()
        {
            // Tests that we expect to return true.
            string[] words = { "Contains Spaces", "Multiple Words", "  Leading Space", "Trailing Space  " };
            foreach (var word in words)
            {
                bool result = StringLibrary.HasEmbeddedSpaces(word);
                Assert.True(result,
                            $"Expected for '{word}': true; Actual: {result}");
            }

            // Tests that we expect to return false.
            string[] noSpaceWords = { "NoSpaces", "SingleWord" };
            foreach (var word in noSpaceWords)
            {
                bool result = StringLibrary.HasEmbeddedSpaces(word);
                Assert.False(result,
                             $"Expected for '{word}': false; Actual: {result}");
            }
        }
    }
}
using SimpleConsoleApp;
using System;
using System.Collections.Generic;


namespace XUnitTest
{
    public class MathFormulasTest
    {
        [Fact]
        public void IsEvenTest()
        {
            var calculator = new MathFormulas();

            int x =1; 
            int y = 2;

            bool xresult = calculator.IsEven(x);
            bool yresult = calculator.IsEven(y);

            Assert.False(xresult);
            Assert.True(yresult);

        }
        [Theory]
        [InlineData(2,1,1)]
       // [InlineData(1,2,1)]
        [InlineData(3,1,2)]   

        public void DiffTest(int x, int y, int expectedValue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Diff(x, y);
            Assert.Equal(result, expectedValue);
        }
        [Theory]
        [InlineData(2, 1, 3)]
        [InlineData(3, 1, 4)]
        public void AddTest(int x, int y, int expectedValue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Add(x, y);
            Assert.Equal(result, expectedValue);
        }

        [Theory]
        [InlineData(new int[3] {1,2,3},6)]
        [InlineData(new int[2] {4, 3 }, 7)]
        public void SumTest(int[] x, int expectedValue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Sum(x);
            Assert.Equal(result, expectedValue);
        }

        [Theory]
        [InlineData(new int[3] { 1, 2, 3 }, 2)]
        [InlineData(new int[2] { 4, 3 }, 3)]
        public void AvgTest(int[] x, int expectedValue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Avg(x);
            Assert.Equal(result, expectedValue);
        }

        [Theory]
        [MemberData(nameof(MathFormulas.Data),MemberType = typeof(MathFormulas))]

        public void Add_MemberData_Test(int x,int y, int expectedValue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Add(x, y);
            Assert.Equal(result, expectedValue);
        }

        [Theory]
        [ClassData(typeof(MathFormulas))]
        public void Add_ClassData_Test(int x, int y, int expectedValue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Add(x, y);
            Assert.Equal(result, expectedValue);
        }
    }
}

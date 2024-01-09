using System;
using System.Collections.Generic;
using System.Collections;

namespace SimpleConsoleApp
{
    public class MathFormulas: IEnumerable<object[]>
    { 
    
        public bool IsEven(int number) => number % 2 == 0;
        public int Diff(int x, int y) => x - y;
        public int Add(int x, int y) => x + y;

        //params keyword >allows the caller to pass a variable number of arguments tothe method.
        public int Sum(params int[] values)
        {
            int sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum;
        }

        public int Avg(params int[] values)
        {
            int sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum / values.Length;
        }
        //Data method initializes a list of object arrays.
        //The IEnumerable interface is used to iterate over the list of object arrays.
   
        public static IEnumerable<object[]> Data =>
         new List<object[]>
            {
             new object[] {1,2,3},
             new object[] {-4,-6,-10},
             new object[] {-2,2,0},
             new object[] {int.MinValue,-1,int.MaxValue},

            };
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { -4, -6, -10 };
            yield return new object[] { -2, 2, 0 };
            yield return new object[] { int.MinValue, -1, int.MaxValue };
        }
        IEnumerator IEnumerable.GetEnumerator() =>GetEnumerator();
     }   
}
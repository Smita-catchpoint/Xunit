using System;
using System.Collections.Generic;

namespace SimpleConsoleApp
{
    public class StringManipulator
    {
        public string Concatenate(string str1, string str2)
        {
            return str1 + str2;
        }

        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { "Hello,", "world!", "Hello,world!" };
                yield return new object[] { "abc", "123!", "abc123!" };
                yield return new object[] { "", "empty!", "empty!" };


            }
        }
    }
}

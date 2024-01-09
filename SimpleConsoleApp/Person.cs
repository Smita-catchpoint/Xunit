﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public bool IsAdult(int age)
        {
            return age >= 18;
        }
    }
}

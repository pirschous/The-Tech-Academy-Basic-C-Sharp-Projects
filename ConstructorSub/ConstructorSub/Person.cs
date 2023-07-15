﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSub
{
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string fullName) : this(fullName, "")
        {

        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}".Trim();
        }
    }
}

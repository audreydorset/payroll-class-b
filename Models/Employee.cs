﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollClassA.Models
{
    public abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }

        public Employee(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {SocialSecurityNumber} -> {Earnings()}";
        }

        public abstract decimal Earnings();
        

        



     

    }
}

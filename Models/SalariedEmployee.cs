using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollClassA.Models
{
    public class SalariedEmployee : Employee
    {

        public SalariedEmployee(string firstName, string lastName, string socialSecurityNumber)
            : base(firstName, lastName, socialSecurityNumber)
        {

        }

        public override decimal Earnings()
        {
            return 4.0M;
        }
    }
}

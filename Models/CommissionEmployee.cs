using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollClassA.Models
{
    public class CommissionEmployee : Employee
    {
        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber)
            : base(firstName, lastName, socialSecurityNumber)
        {

        }

        public override decimal Earnings()
        {
            return 3.0M;
        }
    }
}

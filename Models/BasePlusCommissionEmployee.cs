using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollClassA.Models
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecurityNumber)
            : base(firstName, lastName, socialSecurityNumber)
        {

        }

        public override decimal Earnings()
        {
            return 1.0M;
        }


    }
}


using PayrollClassA.Models;
using System;

namespace PayrollClassA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Payroll........");
          /// Employee ee = new Employee("Bruce", "Wayne", "BAT001");

          //  Console.WriteLine(ee.ToString());

            HourlyEmployee he = new HourlyEmployee("Diane", "Carter", "WW001", 15.0M, 55M);
            Console.WriteLine(he.ToString());


            SalariedEmployee se = new SalariedEmployee("David", "Banner", "HULK001");
            Console.WriteLine(se.ToString());

            CommissionEmployee ce = new CommissionEmployee("Peter", "Parker", "SPIDER001");
            Console.WriteLine(ce.ToString());

            BasePlusCommissionEmployee bce = new BasePlusCommissionEmployee("Clark", "Kent", "SUPER001");
            Console.WriteLine(bce.ToString());



        }
    }
}

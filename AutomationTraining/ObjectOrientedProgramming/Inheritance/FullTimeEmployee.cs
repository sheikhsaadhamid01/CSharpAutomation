using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.ObjectOrientedProgramming.Inheritance
{
    internal class FullTimeEmployee : Employee
    {
        private double _annualSalary;

        public FullTimeEmployee(double annualSalary)
        {
            this._annualSalary = annualSalary;
        }
       public double AnnualSalary { get {  return _annualSalary; } }

    }
}

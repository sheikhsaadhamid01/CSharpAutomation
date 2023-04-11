using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.ObjectOrientedProgramming.Inheritance
{
    internal class PartTimeEmployee : Employee
    {
        private double _hourlyRate;

        public PartTimeEmployee(double hourlyRate)
        {
                this._hourlyRate = hourlyRate;
        }

        public PartTimeEmployee(string firstName, string lastName) :base(firstName, lastName) { }
        

        public double getHourlyRate() { return _hourlyRate; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.ObjectOrientedProgramming.Polymorphism
{
    internal class Trainer
    {
        public string firstName;
        public string lastName;
        public Trainer() { }

        public virtual void PrintFullName()
        {
            Console.WriteLine($"firstname lastname");
        }
    }
}

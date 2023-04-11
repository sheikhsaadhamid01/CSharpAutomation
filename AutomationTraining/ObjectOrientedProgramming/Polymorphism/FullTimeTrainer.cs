using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.ObjectOrientedProgramming.Polymorphism
{
    internal class FullTimeTrainer : Trainer
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"firstname lastname -- Full time");
        }

    }
}

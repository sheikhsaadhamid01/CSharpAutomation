using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.ObjectOrientedProgramming.Polymorphism
{
    internal class PartTimeTrainer : Trainer
    {

       public override void PrintFullName()
        {
            Console.WriteLine( $"firstname lastname -- Part time");
        }


    }
}

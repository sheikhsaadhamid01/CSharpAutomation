using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.DelegatesDemo
{
    public delegate int PerformCalculations(int firstNumber, int secondNumber);
    class Calculator
    {


        public int AddNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int SubtractNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private int MultiplyNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

    }
}

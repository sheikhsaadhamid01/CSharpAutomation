using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.Subjects
{
    internal class MethodParams
    {

        public void MethodWithValueParameter(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Sum of {firstNumber} and {secondNumber} =  {firstNumber+secondNumber}");

        }
        public void MethodWithReferenceParameters(ref int number)
        {
            number += 10;
        }

        public void MethodWithOutParameter(int firstNumber, int secondNumber, out int sum)
        {
            sum = firstNumber + secondNumber;
        }

        public void MethodWithParamsParameter(params int[] numArray)
        {
            Console.WriteLine($"Size of array: {numArray.Length}");
            foreach (var number in numArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}

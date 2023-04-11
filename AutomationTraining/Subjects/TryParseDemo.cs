using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.Subjects
{
    internal class TryParseDemo
    {
        public void DemoTryParse()
        {
            Console.WriteLine("Enter fist number: ");
            string firstNumber = Console.ReadLine();
            int firstInput = ValidateNumber(firstNumber);

            Console.WriteLine("Enter second number: ");
            string secondNumber = Console.ReadLine();
            int secondInput = ValidateNumber(secondNumber);

            Console.WriteLine($"Addition: {firstInput} + {secondInput} = {firstInput + secondInput}");


        }

        private static int ValidateNumber(string number)
        {
            int num = 0;
            bool isValidResponse = int.TryParse(number, out int result);
            if (isValidResponse)
            {
                num = result;
            }
            else
            {
                Console.WriteLine($"Please enter a valid response. {number} is not a valid integer");
            }

            return num;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.ExceptionsDemo
{
    internal class Student
    {
        public void DisplayStudentResults(string name)
        {
            if (name == null)
            {
                throw new StudentNotFoundException("Student is either null or invalid name provided");
            }
            else
            {
                Console.WriteLine($"{name} has secured 90 marks");
            }
        }
    }
}

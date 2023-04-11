using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.ExceptionsDemo
{
    internal class StudentNotFoundException : Exception
    {
        public StudentNotFoundException() : base(){ }

        public StudentNotFoundException(string message) : base(message) { }
    }
}

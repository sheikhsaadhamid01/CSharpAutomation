using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.Generics
{
    internal class GenericsDemo
    {

        public bool IsEqual<T>(T first, T second)
        {
            return first.Equals(second);
        }


    }
}

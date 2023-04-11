using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.ObjectOrientedProgramming.Properties
{
    internal class Student
    {

        private string _status = "Full Time";
        public int Id 
        {
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Id cannot be 0 or a negative value");
                }
                Id = value;
            }
            get 
            {
                return Id;
            }
        }
        public string Name 
        {
        set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Name = "no name";
                }
                Name = value;
            }
        get
            {
                return Name;
            }
        }
        public int Age { set; get; }
        public string Status 
        {
             
            get 
            { 
            return _status; 
            }
        }



    }
}

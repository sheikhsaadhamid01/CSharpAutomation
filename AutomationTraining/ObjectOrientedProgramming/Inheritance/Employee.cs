using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AutomationTraining.ObjectOrientedProgramming.Inheritance
{
    internal class Employee
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phone;
        private string _address;
        private string _city;
        private string _zip;
        private string _country;
        private string _age;
       


        public Employee() 
        {
            Console.WriteLine("Employee class is called");
        }

        public Employee(string firstNamem, String lastNamem)
        {
            _firstName = firstNamem;
            _lastName = lastNamem;
            Console.WriteLine("Constructor with parameters is called.");
        }


        public void DisplayFullName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);
        }

    }
}

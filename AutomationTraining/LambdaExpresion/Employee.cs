using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.LambdaExpresion
{
    internal class Employee
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { this._id = value; }
        }
        public string Name
        {
            get {  return this._name;}
            set { this._name = value; } 
        }

        public Employee(int id, string name) 
        {
            _id = id;
            _name = name;
        }
    }
}

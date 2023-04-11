using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.LambdaExpresion
{
    internal class LambdaDemo
    {

        public void Demo()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(10, "Saad"));
            employees.Add(new Employee(11, "Alex"));
            employees.Add(new Employee(12, "Steve"));
            employees.Add(new Employee(13, "David"));
            employees.Add(new Employee(14, "Stefan"));

            Console.WriteLine( $"count of employees starts with S: {employees.Count(x=> x.Name.StartsWith("A"))}");
            Console.WriteLine($"Total count of employeed: {employees.Count()}");

            try
            {
                Employee emp = employees.Single(emp => emp.Name.Equals("Alen"));


                Console.WriteLine(emp.Name);
            }
            

            catch(Exception ex)
            {
                Console.WriteLine($"Element not found due to error: {ex.Message}" );
            }
          
            
           
            //Console.WriteLine($"Name of Employee: {employees.Single(emp => emp.Name.Equals("Saad"))}");


        }
    }
}

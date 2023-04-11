using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.DictionariesDemo
{
    internal class World
    {

        public void DisplayCountriesAndStates()
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries.Add("Pakistan", "Islambad");
            countries.Add("New zealnd", "Wellington");
            countries.Add("Germany", "Munich");
            countries.Add("UK", "London");

            foreach (KeyValuePair<string,string> country in countries) 
            {
                Console.WriteLine( $"country name: {country.Key}, Capital name: {country.Value}");
            }


            Console.WriteLine(  );
            Console.WriteLine("List of Countries");
            foreach (var item in countries.Keys)
            {
                Console.WriteLine( item );
            }
            Console.WriteLine();
            Console.WriteLine(  "List of Capitals");
            foreach (var item in countries.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}

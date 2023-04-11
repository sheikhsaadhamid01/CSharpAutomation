using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.Excercises
{
    internal class ArrayExcercises
    {

        public void InsertElementsInArray()
        {
            Console.Write("Enter size of an array: ");
            int.TryParse(Console.ReadLine(), out int sizeOfArray);
            int[] numberArray = new int[sizeOfArray];
            Console.WriteLine();
            for (int i = 0; i < sizeOfArray; i++) 
            {
                Console.Write("Enter number: ");
                bool isValidNumber = int.TryParse(Console.ReadLine(), out int number);
                if (isValidNumber)
                {
                    numberArray[i] = number;
                }
                else
                {
                    Console.WriteLine("Invalid input provided, default value of 0 will be stored in an array");
                }
                Console.WriteLine();
            }

            if(numberArray.Length < 1)
            {
                Console.WriteLine("There are no numbers added in an array");
            }
            else
            {
                Console.WriteLine("Elements in a Array");
                foreach (int i in numberArray)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    
        public void DisplayArrayInReverseOrder()
        {
            Console.Write("Enter size of an array: ");
            bool isValidSize = int.TryParse(Console.ReadLine(),out int size);
            int sizeOfArray = isValidSize ? size : -1;
            Console.WriteLine();
            if(sizeOfArray < 0)
            {
                Console.WriteLine("Invalid Array size provided");
            }
            else
            {
                int[] numArray = new int[sizeOfArray];
                for (int i = 0; i < numArray.Length; i++)
                {
                    Console.Write("Enter number: ");
                    bool isValidInput = int.TryParse(Console.ReadLine(),out int number);
                    if (isValidInput)
                    {
                        numArray[i] = number;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input provided. Stored 0 as default number on {i} index of array");
                    }
                }

                Console.WriteLine("Displaying Array contents in reverese order");
                for (int i = numArray.Length-1; i >=0; i--)
                {
                    Console.WriteLine(numArray[i]);
                }    



            }


        }

        public void DuplicateElementsInAnArray()
        {
            Console.Write("Please entery size of an array: ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int sizeOfArray);
            Console.WriteLine();
            if (!isValidInput)
            {
                Console.WriteLine("Invalid size of an arrray is provided");
                return;
            }
            else
            {
                int[] numArray = new int[sizeOfArray];
                for (int i = 0; i < numArray.Length; i++)
                {
                    Console.Write("Enter number: ");
                    isValidInput = int.TryParse(Console.ReadLine(), out int number);
                    if (isValidInput)
                    {
                        numArray[i] = number;
                        Console.WriteLine();
                    }
                    else 
                    { 
                       Console.WriteLine($"Incorrect number added in an array. 0 is set as default value on laction {i} of array"); 
                    }
                    
                }
                //Verifying Duplicates in an Array
                int count = 0;
              
          
                List<int> nums = new List<int>(numArray); ;

               HashSet<int> set = new HashSet<int>(nums);

                int sizeOfList = nums.Count;
                int sizeOfSet = set.Count;
                int totalDuplicatesRemoved = sizeOfList - sizeOfSet;
                /*

                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums.IndexOf(nums[i]) != nums.LastIndexOf((nums[i])))
                    {
                        count++;
                        nums.Remove(nums[i]);
                    }

                }
                */
              
                Console.WriteLine($"Total number of Duplicates in Array: {totalDuplicatesRemoved}");

            }

        }
    
        public void PrintAllUniqueNumbers()
        {
            Console.Write("Enter size of an Array: ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int size);
            Console.WriteLine();
            if (!isValidInput) 
            {
                Console.WriteLine("Invalid size of an array is provided");
            }
            else
            {
                int[] numArray = new int[size];
                List<int> uniqueNumbers = new List<int>();
                for(int i = 0; i<numArray.Length; i++)
                {
                    Console.Write("Enter number: ");
                    bool isValidNumber = int.TryParse(Console.ReadLine(),out int number);
                    if(isValidNumber)
                    {
                        numArray[i] = number;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input provided. 0 is set as default value");
                    }


                }

                for(int i = 0; i<numArray.Length;i++)
                {
                    if (Array.IndexOf(numArray, numArray[i]) == Array.LastIndexOf(numArray, numArray[i]))
                    {
                        uniqueNumbers.Add(numArray[i]);

                    }

                }
                

                foreach (int uniqueNumber in uniqueNumbers) 
                {
                    Console.WriteLine(uniqueNumber);
                }
            }
        }
    
        public void FindFrequencyOfNumber()
        {
            Console.Write("Enter size of an Array: ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int size);
            if(!isValidInput & size < 0) { Console.WriteLine("Invalid input provided for size of an Array"); }
            else
            {
                if (size >= 0)
                {
                    Console.WriteLine();
                    int[] numberArray = new int[size];
                    for (int i = 0; i < numberArray.Length; i++)
                    {
                        Console.Write("Enter number: ");
                        String userInput = Console.ReadLine();
                        bool isValidNumber = int.TryParse(userInput, out int number);
                        if (isValidInput && !(String.IsNullOrEmpty(userInput)))
                        {
                            numberArray[i] = number;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"Invalid input provided. 0 is set as a default value on position {i} of number Array");
                        }
                    }
                    int count = 0;
                    // Frequency of number
                    List<string> output = new List<string>();
                    HashSet<string> uniqueResults = new HashSet<string>();
                    for (int i = 0; i < numberArray.Length; i++)
                    {
                        int number = numberArray[i];

                        for(int j = 0; j < numberArray.Length; j++)
                        {
                            if (numberArray[j] == number)
                            {
                                count++;

                            }

                            if (j == numberArray.Length - 1)
                            {
                                output.Add($"Frequency of {number} is {count}");
                                count = 0;
                                
                            }
                        }                    
                       

                    }

                   uniqueResults = output.ToHashSet();
                    foreach (string uniqueResult in uniqueResults) { Console.WriteLine(uniqueResult); }




                }
            }

        }
    }
}

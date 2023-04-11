using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutomationTraining.ExceptionsDemo
{
    internal class FileHandling
    {
        StreamReader reader;

        public void ReadFile()
        {
            try
            {
                reader = new StreamReader("C:\\Users\\shamid\\Documents\\File1.txt");
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();
            }
            catch (FileNotFoundException fe) 
            {
                Console.WriteLine($"Message: File not available. Error: {fe.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"General Message: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
            }

            finally 
            {
                Console.WriteLine("Closing the execution");
            }
             
            


        }
    }
}

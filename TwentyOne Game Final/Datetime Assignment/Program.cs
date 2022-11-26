using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("System Current date and time is: "+ DateTime.Now +"\n");
            Console.WriteLine("Please enter any number: ");
            string userInput = Console.ReadLine();

            Console.WriteLine("\n"+DateTime.Now.Hour + ":"+DateTime.Now.Minute+":"+DateTime.Now.Second + "    " +userInput);
            Console.WriteLine("\n The number *** " + userInput + " *** Entered at " + DateTime.Now.TimeOfDay);

            Console.ReadLine();

        }
    }
}

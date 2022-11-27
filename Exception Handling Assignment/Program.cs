using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try     // 3. Exceptions must be handled using “try/catch.”
            {

                int userAge;

                Console.WriteLine("Please enter your Age? ");       // 1. Ask the user for their age.
                userAge = Convert.ToInt32(Console.ReadLine());

                if(userAge == 0)        // 4. Display appropriate error messages if the user enters zero or negative numbers.
                {
                    Console.WriteLine("Zero Number is not allowed! ");
                }
                else if(userAge < 0)
                {
                    Console.WriteLine("Please enter the positive number.");
                }
                else
                {
                    int userDoB = DateTime.Now.Year - userAge;
                    Console.WriteLine("Your Year of birth is: " + userDoB);     //2. Display the year the user was born.
                }

            }

            catch (Exception)       //5. Display a general message if an exception was caused by anything else.
            {
                Console.WriteLine("An error occurred, please contact your system administrator.");
                Console.ReadLine();
                return;
            }

            Console.ReadLine();
        }
    }
}

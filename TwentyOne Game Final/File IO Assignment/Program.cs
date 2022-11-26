using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1

            Console.WriteLine("Please enter your phone number to save into the system \n");
            string phoneNumber = Console.ReadLine();

            using (StreamWriter userInput = new StreamWriter(@"C:\Users\Public\Documents\log.txt", true))
            {
                userInput.WriteLine(DateTime.Now +"   " + phoneNumber +"\n");
            }
            Console.WriteLine("\n" + "The phone number: " + "*** " + phoneNumber + " *** " + " Successfully added to a text file \n");
            Console.WriteLine("To view a text file, please visit " + "C:\\Users\\Public\\Documents\\log.txt");

            // Example 2

            //Console.WriteLine("Please enter your phone number to save into the system \n");
            //string phoneNumber = Console.ReadLine();
            //File.WriteAllText(@"C:\Users\Public\Documents\log.txt", phoneNumber);
            //string readPhoneNum = File.ReadAllText(@"C:\Users\Public\Documents\log.txt");


            //Console.WriteLine("\n"+"The phone number: "+"*** "+readPhoneNum+" *** "+" Successfully added to a text file \n");
            //Console.WriteLine("To view a text file, please visit "+ "C:\\Users\\Public\\Documents\\log.txt");

            Console.ReadLine();
            
        }
    }
}

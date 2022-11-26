using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newEmployee = new constChain("Noorahmad Noor");  // creating a variable using var and passing just Name. the default ID '100' will assign
            constChain newEmployee1 = new constChain(200,"Jesse"); // createing another veriable, passing the ID and name.


            Console.WriteLine("Employee ID: "+newEmployee.id +"\n"+"Employee Name: "+ newEmployee.Name +"\n");
            Console.WriteLine("Employee ID: " + newEmployee1.id + "\n" + "Employee Name: " + newEmployee1.Name);





            Console.ReadLine();


        }
    }
}

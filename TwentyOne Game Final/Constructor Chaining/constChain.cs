using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining
{
    public class constChain
    {
        // calling of contructor from another constructor


        
        public int id;
        public string Name;
    
        public constChain(string Name):this(100,Name)   // this constructor take name from name, if not assign the ID it will assign 100.
        {

        }

        public constChain(int id, string Name)
        {
            this.Name = Name;
            this.id = id;   
        }

    }
}

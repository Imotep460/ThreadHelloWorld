using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadHelloWorld
{
    class Menu
    {
        public string HovedMenu()
        {
            Console.WriteLine("1. Hello World 1 - Metode");
            Console.WriteLine("2. Hello World 2 - Lambda");
            Console.WriteLine("3. Hello World 3 - Anonym");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");
            return Console.ReadLine();
        }
    }
}

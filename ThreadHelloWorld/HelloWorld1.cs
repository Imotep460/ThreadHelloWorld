using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadHelloWorld
{
    public delegate void ThreadStart();
    class HelloWorld1
    {
        public void Basic()
        {
            Thread t = new Thread(Go);
            t.Start();
            Go();
        }
        public void Go()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadHelloWorld
{
    class HelloWorld2
    {
        public void Go2()
        {
            Thread d = new Thread(() =>
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Hello World");
                }
            }
            );
            
            d.Start();
        }
    }
}

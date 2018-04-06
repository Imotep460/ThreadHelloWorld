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
            Thread t = new Thread(() => Console.WriteLine("Hello World"));
            Thread s = new Thread(() => Console.WriteLine("Hello World"));
            Thread a = new Thread(() => Console.WriteLine("Hello World"));
            t.Start();
            s.Start();
            a.Start();
        }
    }
}

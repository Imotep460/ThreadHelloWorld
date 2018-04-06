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
        }
        private void Go()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hej Verden");
            }
        }        
    }
}

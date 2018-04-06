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
            t.Start("Hello World");
        }
        private void Go(object Text)
        {
            string t1 = (string)Text;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Text);
            }
        }        
    }
}

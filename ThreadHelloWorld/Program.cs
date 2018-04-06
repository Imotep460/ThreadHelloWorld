using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        internal void Run()
        {
            bool running = true;
            while (running)
            {
                Menu menu = new Menu();
                string s = menu.HovedMenu();
                switch (s)
                {
                    case "1": StartHelloWrold1(); break;
                    case "2": StartHelloWorld2(); break;
                    //case "3": HelloWorld3(); break;
                    case "4": running = false; break;
                }
            }
        }

        private void StartHelloWrold1()
        {
            HelloWorld1 helloWorld1 = new HelloWorld1();
            helloWorld1.Basic();
        }
        private void StartHelloWorld2()
        {
            HelloWorld2 helloWorld2 = new HelloWorld2();
            helloWorld2.Go2();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Some some stuff in.");
            var a = Console.ReadLine();
            Console.WriteLine(a);
            if (a == "hi")
            {
                for (int i =0; i<a.Length; i++) {
                    Console.WriteLine("k");
                }
                Console.WriteLine("k");
            }
            else
            {
                foreach (char item in a) {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static float getNumber()
        {
            Console.Write("variable=");
            float b = float.Parse(Console.ReadLine());
            return b;

        }
        private static string action()
        {
            Console.Write("action=");
            string znak = Console.ReadLine();
            return znak;
        }
        private static float result()
        {
            float c = 0;
            {
                float one = getNumber();
                { string act = action();
                    switch (act)
                    {
                        case ("-"):
                            c = one - getNumber();
                            break;
                        case ("+"):
                            c = one + getNumber();
                            break;
                        case ("*"):
                            c = one * getNumber();
                            break;
                        case ("/"):
                            c = one / getNumber();
                            break;
                    }
                    return c;
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Result=" + result());
                Console.ReadKey();
            }
        }
    }
}



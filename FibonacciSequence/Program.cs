using System;
using System.Linq;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int howmuch;
            float basenum;
            float befnum = 0;
            float nextnum = 0;

            Console.Write("Insert how much numbers you want (can't be 0): ");
            int.TryParse(Console.ReadLine(), out howmuch);
            Console.Clear();
            while (howmuch == 0)
            {
                Console.WriteLine("Insert valid number!");
                Console.Write("Insert how much numbers you want (can't be 0): ");
                int.TryParse(Console.ReadLine(), out howmuch);
                Console.Clear();
            }

            Console.Write("Insert base number (can't be 0): ");
            float.TryParse(Console.ReadLine(), out basenum);
            Console.Clear();
            while (basenum == 0)
            {
                Console.WriteLine("Insert valid number!");
                Console.Write("Insert base number (can't be 0): ");
                float.TryParse(Console.ReadLine(), out basenum);
                Console.Clear();
            }

            float[] pole = new float[howmuch];
            float acnum = basenum;
            int onetwo = 1;
            int first = 1;
            for (int ac = 0; ac < howmuch; ac++)
            {
                if (onetwo == 1)
                {
                    befnum = acnum;
                    onetwo = 2;

                }
                else if (onetwo == 2)
                {
                    nextnum = acnum;
                    onetwo = 1;
                    if (first == 1)
                    {
                        befnum = 0;
                        first = 2;
                    }
                }

                acnum = befnum + nextnum;
                pole[ac] = acnum;

            }

            Console.Write("Max value: ");
            Console.WriteLine(pole.Max());
            Console.Write("Sumary of all numbers: ");
            Console.WriteLine(pole.Sum());
            Console.WriteLine();
            Console.Write("Press anything to exit.");
            Console.ReadKey();

        }
    }
}

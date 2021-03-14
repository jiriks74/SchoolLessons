using System;
using System.Linq;

namespace GeometricSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int howmuch;
            float basenum;
            float nextnum;

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

            Console.Write("Insert what to add to next power of the number: (can't be 0): ");
            float.TryParse(Console.ReadLine(), out nextnum);
            Console.Clear();
            while (nextnum == 0)
            {
                Console.WriteLine("Insert valid number!");
                Console.Write("Insert what to add to next number: (can't be 0): ");
                float.TryParse(Console.ReadLine(), out nextnum);
                Console.Clear();
            }

            double[] pole = new double[howmuch];
            float acnum = basenum;
            float ttt = nextnum;
            for (int ac = 0; ac < howmuch; ac++)
            {
                pole[ac] = Math.Pow(acnum, ttt);
                ttt += nextnum;
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

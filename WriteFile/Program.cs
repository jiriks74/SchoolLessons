using System;
using System.Collections.Generic;

namespace WriteFile
{
    class Program
    {
        static int write()
        {
            int numberoflines;
            List<string> file = new List<string>();
            string nameoffile;

            Console.Write("Insert file path: ");
            nameoffile = Console.ReadLine();
            Console.Clear();

            Console.Write("Number of lines: ");
            int.TryParse(Console.ReadLine(), out numberoflines);
            Console.Clear();

            for (int aline = 0; aline < numberoflines; aline++)
            {
                Console.Write(aline);
                Console.Write(". line: ");
                file.Add(Console.ReadLine());
            }
            System.IO.File.WriteAllLines(nameoffile, file);
            return (1);
        }

        static void Main(string[] args)
        {
            int exit;
            exit = write();
        }
    }
}

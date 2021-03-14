using System;
using System.Collections.Generic;

namespace TxtEditor
{
    class Program
    {
        static int choosein()
        {
            int operationn;
            Console.WriteLine("***************************");
            Console.WriteLine("Welcome to txt file editor.");
            Console.WriteLine("***************************");
            Console.WriteLine();
            Console.WriteLine("Insert number of operation:");
            Console.WriteLine("     1 for read");
            Console.WriteLine("     2 for write");
            Console.WriteLine("     3 for exit");
            Console.Write("I choose: ");

            int.TryParse(Console.ReadLine(), out operationn);
            Console.Clear();
            if (operationn == 0 | operationn > 3)
            {
                int restart = 0;
                Console.WriteLine("You've inserted unexpected value.");
                Console.WriteLine("Restarting program...");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                return (restart);
            }
            else
            {
                Console.Clear();
                return (operationn);
            }
        }

        static int write()
        {
            int restart = 0;
            int numberoflines;
            List<string> file = new List<string>();
            string nameoffile;
            string dir;

            Console.Write("Insert file where to save file: <C:/Dir/> ");
            dir = Console.ReadLine();
            Console.Clear();

            bool testdir = System.IO.Directory.Exists(dir);
            if (testdir == false)
            {
                Console.WriteLine("Directory doesn't exixts.");
                Console.WriteLine("Restarting program...");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                return (0);
            }

            Console.Write("Insert name of file file <File.txt>: ");
            nameoffile = Console.ReadLine();
            Console.Clear();

            Console.Write("Number of lines: ");
            int.TryParse(Console.ReadLine(), out numberoflines);
            Console.Clear();
            while (numberoflines == 0)
            {
                Console.WriteLine("Can't be anything but number or zero.");
                Console.WriteLine();
                Console.Write("Number of lines: ");
                int.TryParse(Console.ReadLine(), out numberoflines);
                Console.Clear();
            }
            Console.WriteLine(dir + nameoffile);
            Console.WriteLine();

            for (int aline = 0; aline < numberoflines; aline++)
            {
                Console.Write(aline);
                Console.Write(". line: ");
                file.Add(Console.ReadLine());
            }
            System.IO.File.WriteAllLines(dir + nameoffile, file);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press Enter to continue or insert 1 to exit: ");
            int.TryParse(Console.ReadLine(), out restart);
            Console.Clear();
            return (restart);
        }

        static int read()
        {
            int restart = 0;
            string nameoffile;
            Console.Write("Insert file path <C/Dir/File.txt/>: ");
            nameoffile = Console.ReadLine();
            Console.Clear();

            bool check = System.IO.File.Exists(nameoffile);
            if (check == true)
            {
                System.IO.File.Exists(nameoffile);
                string[] test = System.IO.File.ReadAllLines(nameoffile);
                var lineCount = System.IO.File.ReadAllLines(nameoffile).Length;

                Console.Write("File path: ");
                Console.WriteLine(nameoffile);
                Console.WriteLine();
                for (int line = 0; line < lineCount; line++)
                {
                    Console.WriteLine(test[line]);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Press Enter to continue or insert 1 to exit: ");
                int.TryParse(Console.ReadLine(), out restart);
                Console.Clear();
                return (restart);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
                Console.Write("Restarting program...");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                return (0);
            }
        }

        static void Main(string[] args)
        {
            while (0 == 0)
            {
                int choose;
                int exit;
                choose = choosein();
                if (choose == 1)
                {
                    exit = read();
                    if (exit == 1)
                    {
                        break;
                    }
                }
                else if (choose == 2)
                {
                    exit = write();
                    if (exit == 1)
                    {
                        break;
                    }
                }
                else if (choose == 3)
                {
                    break;
                }
            }
        }
    }
}

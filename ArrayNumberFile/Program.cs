using System;

namespace ArrayNumberFile
{
    class Program
    {
        static string main()
        {
            string nameoffile;

            Console.WriteLine("Insert file path or 'e' to exit.");
            Console.WriteLine("File can contain only one zero and can't contain letters.");
            Console.Write("File path: ");

            nameoffile = Console.ReadLine();
            Console.Clear();

            if (nameoffile == "e")
            {
                return (nameoffile);
            }

            bool check = System.IO.File.Exists(nameoffile);
            if (check == true)
            {
                System.IO.File.Exists(nameoffile);
                string[] test = System.IO.File.ReadAllLines(nameoffile);
                var lineCount = System.IO.File.ReadAllLines(nameoffile).Length;

                int[] array = new int[lineCount];

                for (int numm = 0; numm < lineCount; numm++)
                {
                    int.TryParse(test[numm], out array[numm]);
                }

                int zeros = 0;

                for (int ch = 0; ch < lineCount; ch++)
                {
                    if (array[ch] == 0)
                    {
                        zeros++;
                    }
                }

                if (zeros > 1)
                {
                    Console.WriteLine("Error, file contains letters.");
                    Console.Write("Restarting program...");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    return ("0");
                }

                Array.Sort(array);

                Console.Write("File path: ");
                Console.WriteLine(nameoffile);
                Console.WriteLine();

                for (int al = 0; al < lineCount; al++)
                {
                    int line = al++;
                    int num = 1;
                    if (al < 9)
                    {
                        if (num <= 4)
                        {
                            Console.Write(" ");
                            Console.Write(line);
                            Console.Write(".)  ");
                            Console.Write(array[al]);
                            Console.Write("     ");
                            num++;
                        }
                        else if (num > 4)
                        {
                            Console.WriteLine();
                            num = 1;
                        }

                    }
                    else
                    {
                        if (num <= 4)
                        {
                            Console.Write(" ");
                            Console.Write(line);
                            Console.Write(".)  ");
                            Console.Write(array[al]);
                            Console.Write("     ");
                            num++;
                        }
                        else if (num > 4)
                        {
                            Console.WriteLine();
                            num = 1;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Do you want to save result to file?");
                Console.Write("Insert 'y' for yes or press enter to continue: ");
                string save;
                save = Console.ReadLine();
                Console.Clear();

                if (save == "y")
                {
                    string namefile;
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
                        return ("0");
                    }

                    Console.Write("Insert name of file file <File.txt>: ");
                    namefile = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine(dir + nameoffile);
                    Console.WriteLine();

                    string[] file = new string[lineCount];

                    for(int cl = 0; cl < lineCount; cl++)
                    {
                        file[cl] = Convert.ToString(array[cl]);
                    }

                    System.IO.File.WriteAllLines(dir + namefile, file);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insert 'e' for exit or press enter for continue: ");
                    Console.Clear();
                }
            }

            else
            {
                Console.WriteLine("File doesn't exist");
                Console.Write("Restarting program...");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                return ("0");
            }
            return ("0");
        }
        static void Main(string[] args)
        {
            while (0 == 0)
            {
                string exit;
                exit = main();
                if(exit == "e")
                {
                    return;
                }
            }
        }
    }
}

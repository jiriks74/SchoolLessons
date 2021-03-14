using System;

namespace Calc2._0
{
    class Program
    {
        static float value1in()
        {
            float value1;

            Console.WriteLine("Do not insert letter or only 0.");
            Console.Write("1st number = ");
            float.TryParse(Console.ReadLine(), out value1);
            Console.Clear();
            return (value1);
        }

        static float value2in()
        {
            float value2;

            Console.WriteLine("Do not insert letter or only 0.");
            Console.Write("2nd number = ");
            float.TryParse(Console.ReadLine(), out value2);
            Console.Clear();
            return (value2);
        }

        static int operationin()
        {
            int operationn;
            Console.Write("I choose: ");
            int.TryParse(Console.ReadLine(), out operationn);
            Console.Clear();
            return (operationn);
        }

        static int print()
        {
            int operation;
            int doo;
            float val1;
            float val2;

            int restart = 99;

            Console.WriteLine("############################");
            Console.WriteLine("Welcome to Calculator 2.0 :)");
            Console.WriteLine("############################");
            Console.WriteLine("Please, do not enter letters or just 0");
            Console.WriteLine("For decimal numbers use '.' ");
            Console.WriteLine();
            Console.WriteLine("Insert number of operation:");
            Console.WriteLine("     1 for +");
            Console.WriteLine("     2 for -");
            Console.WriteLine("     3 for *");
            Console.WriteLine("     4 for /");
            Console.WriteLine("     5 for power");
            Console.WriteLine("     6 for square root");
            Console.WriteLine("     7 for exit");

            operation = operationin();

            if (operation == 7)
            {
                doo = 1;
                return (doo);
            }
            else if (operation != 0 && operation <= 6)
            {

                val1 = value1in();
                val2 = value2in();

                if (val1 != 0 && val2 != 0)
                {
                    if (operation == 1)
                    {
                        Console.Clear();
                        Console.Write(val1);
                        Console.Write(" + ");
                        Console.Write(val2);
                        Console.Write(" = ");
                        Console.WriteLine(val1 += val2);
                        Console.WriteLine();
                        Console.Write("Insert anything to continue or 1 to exit: ");
                        int.TryParse(Console.ReadLine(), out doo);
                        Console.Clear();
                        if (doo == 1)
                        {
                            return (doo);
                        }
                        else
                        {
                        }
                    }
                    else if (operation == 2)
                    {
                        Console.Clear();
                        Console.Write(val1);
                        Console.Write(" - ");
                        Console.Write(val2);
                        Console.Write(" = ");
                        Console.WriteLine(val1 -= val2);
                        Console.WriteLine();
                        Console.Write("Insert anything to continue or 1 to exit: ");
                        int.TryParse(Console.ReadLine(), out doo);
                        Console.Clear();
                        if (doo == 1)
                        {
                            return (doo);
                        }
                        else
                        {
                        }
                    }
                    else if (operation == 3)
                    {
                        Console.Clear();
                        Console.Write(val1);
                        Console.Write(" * ");
                        Console.Write(val2);
                        Console.Write(" = ");
                        Console.WriteLine(val1 *= val2);
                        Console.WriteLine();
                        Console.Write("Insert anything to continue or 1 to exit: ");
                        int.TryParse(Console.ReadLine(), out doo);
                        Console.Clear();
                        if (doo == 1)
                        {
                            return (doo);
                        }
                        else
                        {
                        }
                    }
                    else if (operation == 4)
                    {
                        Console.Clear();
                        Console.Write(val1);
                        Console.Write(" / ");
                        Console.Write(val2);
                        Console.Write(" = ");
                        Console.WriteLine(val1 /= val2);
                        Console.WriteLine();
                        Console.Write("Insert anything to continue or 1 to exit: ");
                        int.TryParse(Console.ReadLine(), out doo);
                        Console.Clear();
                        if (doo == 1)
                        {
                            return (doo);
                        }
                        else
                        {
                        }
                    }
                        else if (operation == 5)
                    {
                        Console.Clear();
                        Console.Write(val1);
                        Console.Write(" power ");
                        Console.Write(val2);
                        Console.Write(" = ");
                        Console.WriteLine(Math.Pow(val1, val2));
                        Console.WriteLine();
                        Console.Write("Insert anything to continue or 1 to exit: ");
                        int.TryParse(Console.ReadLine(), out doo);
                        Console.Clear();
                        if (doo == 1)
                        {
                            return (doo);
                        }
                        else
                        {
                        }
                    }
                    else if (operation == 6)
                    {
                        float square;
                        Console.Clear();
                        square = 1/val1;
                        Console.Write(val1);
                        Console.Write(" square root ");
                        Console.Write(val2);
                        Console.Write(" = ");
                        Console.WriteLine(Math.Pow(val2, square));
                        Console.WriteLine();
                        Console.Write("Insert anything to continue or 1 to exit: ");
                        int.TryParse(Console.ReadLine(), out doo);
                        Console.Clear();
                        if (doo == 1)
                        {
                            return (doo);
                        }
                        else
                        {
                        }
                    }

                    else
                    {
                        Console.WriteLine("Error, you've inserted unexpected value.");
                        Console.Write("Restarting program...");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        return (restart);
                    }
                }
                else if (val1 == 0 | val2 == 0)
                {
                    Console.WriteLine("Error, you've inserted unexpected value/s.");
                    Console.Write("Restarting program...");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    return (restart);
                }
                else
                {
                    Console.WriteLine("Unexpected error.");
                    Console.Write("Restarting program...");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    return (restart);
                }
            }
            else if (operation == 0 | operation >= 8)
            {
                Console.WriteLine("Error, you've inserted unexpected value.");
                Console.Write("Restarting program...");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                return (restart);
            }
            else
            {
                Console.WriteLine("Unexpected error.");
                Console.Write("Restarting program...");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                return (restart);
            }

            doo = 8;
            return (doo);
        }

        static void Main(string[] args)
        {
            while (0 == 0)
            {
                int exit = print();
                if (exit == 1)
                {
                    return;
                }
                else
                {
                }
            }
        }
    }
}

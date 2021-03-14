using System;

namespace Calculator
{
    class Program
    {
        static int value1in()
        {
            int value11;
            Console.Write("Insert 1st number: ");  
            value11 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return (value11);
        }

        static int value2in()
        {
            int value22;
            Console.Write("Insert 2nd number: ");
            value22 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return (value22);
        }

        static int operationin()
        {
            int operationn;

            Console.WriteLine("Insert:");
            Console.WriteLine("1.) 1 to +");
            Console.WriteLine("2.) 2 to -");
            Console.WriteLine("3.) 3 to 1st*2nd");
            Console.WriteLine("4.) 4 to 1st/2nd");
            Console.WriteLine("5.) 5 to exit");
            Console.Write("My choice: ");
            operationn = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.Clear();
            return (operationn);
        }

        static void Main(string[] args) //Main function
        {
            int value1 = value1in(); //Calls value1in function to get 1st value
            int value2 = value2in(); //Calls value2in function to get 2nd value

            int operation = operationin(); //Calls operationin function to get operation value

            if (operation == 1) //
            {
                Console.Write("+");
                Console.Clear();
            }
            if (operation == 2)
            {
                Console.Write("-");
                Console.Clear();
            }
            if (operation == 3)
            {
                Console.Write("*");
                Console.Clear();
            }
            if (operation == 4)
            {
                Console.Write("/");
                Console.Clear();
            }
            if (operation == 5)
            {
                Console.Clear();
                return;
            }

        }
    }
}

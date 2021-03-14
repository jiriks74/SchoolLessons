using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static string generateNums()
        {
            return ("r");
        }
        static string randomNum()
        {
            string opp;
            string call;
            Console.WriteLine("Choose operation: ");
            Console.WriteLine("     'r' for Generating random number.");
            Console.WriteLine("     'e' for exiting the program.");
            Console.Write("I choose: ");
            opp = Console.ReadLine();
            Console.Clear();
            if(opp == "r")
            {
                call = randomNum();
            }
            else if(opp == "e")
            {
                return ("e");
            }
            else
            {
                Console.WriteLine("Unexpected value.");
                Console.WriteLine("Restarting the program...");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                return("sss");
            }
            return ("sss");
        }

        static void Main(string[] args)
        {
            string exit;
            while (0 == 0)
            {
                exit = randomNum();
                if (exit == "e")
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

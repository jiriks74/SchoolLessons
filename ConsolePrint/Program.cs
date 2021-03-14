using System;

namespace ConsolePrint
{
    class Program
    {
        static int waitin()
        {
            int waitinn;
            Console.Write("Insert number of time between copies (in seconds): ");
            waitinn = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            waitinn *= 1000;
            return (waitinn);
        }

        static string countryin()
        {
            string Countryy;
            Console.Write("Insert name of country: ");
            Countryy = Console.ReadLine();
            Console.Clear();
            return (Countryy);
        }

        static string townin()
        {
            string Townn;
            Console.Write("Insert name of town: ");
            Townn = Console.ReadLine();
            Console.Clear();
            return (Townn);
        }

        static string housein()
        {
            string Housee;
            Console.Write("Insert number oh house: ");
            Housee = Console.ReadLine();
            Console.Clear();
            return (Housee);
        }
        
        static string streetin()
        {
            string Streett;
            Console.Write("Inser name of street: ");
            Streett = Console.ReadLine();
            Console.Clear();
            return (Streett);
        }

        static int howmanyin()
        {
            int HowManyy;
            Console.Write("Insert number of copies: ");
            HowManyy = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return (HowManyy);
        }


        static void Main(string[] args)
        {

            int howMany = howmanyin(); //How many copies
            int wait = waitin(); //Time to wait between copies

            //Adress
            string country = countryin();
            string town = townin();
            string house = housein();
            string street = streetin();

            while (howMany > 0)
            {
                Console.Write("street: "); //Prints "Street: <Name of street>"
                Console.WriteLine(street);
                Console.Write("house: "); //Prints "House: <House number>"
                Console.WriteLine(house);
                Console.Write("town: "); //Prints "Town: <Name of town>"
                Console.WriteLine(town);
                Console.Write("country: "); //Prints "Country: <Name of country>"
                Console.WriteLine(country);
                Console.WriteLine("__________________________________________________________");
                howMany -= 1;
                System.Threading.Thread.Sleep(wait);
            }
        }
    }
}

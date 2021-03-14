using System;

namespace FileRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameoffile;
            Console.Write("Insert file path: ");
            nameoffile = Console.ReadLine();

            //string dir = "D:";
            //string name = "test.txt";
            //string print = dir + name;
            //Console.Write(print);

            bool testt = System.IO.File.Exists(nameoffile);
            Console.WriteLine(testt);

            string[] test = System.IO.File.ReadAllLines(nameoffile);
            var lineCount = System.IO.File.ReadAllLines(nameoffile).Length;

            for (int line = 0; line < lineCount; line++)
            {
                Console.WriteLine(test[line]);
            }
            System.Threading.Thread.Sleep(10000);
        }
    }
}

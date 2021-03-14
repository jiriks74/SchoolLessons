using System;

namespace NumberSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random test = new Random();
            int nOne;
            string[] pole = new string[100];
            for (int n = 0; n < 100; n++)
            {
                nOne = test.Next(1, 10000);
                pole[n] = Convert.ToString(nOne);
            }
            Console.WriteLine("Random generated numbers:");
            Console.WriteLine();
            for (int l = 0; l < 100; l++)
            {
                Console.Write(pole[l]);
                Console.Write(", ");
            }
            int[] nums = new int[100];
            for (int c = 0; c < 100; c++)
            {
                nums[c] = Convert.ToInt32(pole[c]);
            }
            Array.Sort(nums);
            string result = String.Join(",", nums);
            result = result.Replace(",", System.Environment.NewLine);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Result (from smallest to biggest:");
            Console.WriteLine();
            for (int al = 0; al < 100; al++)
            {
                int l3 = 1;
                if (al <= 8)
                {
                    while (l3 <= 3)
                    {
                        Console.Write("     ");
                        Console.Write(" ");
                        Console.Write(al += 1);
                        Console.Write(".) ");
                        Console.Write(nums[al]);
                        
                        l3++;
                    }
                    if (l3 >= 4)
                    {
                        Console.WriteLine();
                        l3 = 1;
                    }
                }
                else
                {
                    while (l3 <= 3)
                    {
                        Console.Write("     ");
                        Console.Write(al += 1);
                        Console.Write(".) ");
                        Console.Write(nums[al]);
                        
                        l3++;
                    }
                    if (l3 >= 4)
                    {
                        Console.WriteLine();
                        l3 = 1;
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}

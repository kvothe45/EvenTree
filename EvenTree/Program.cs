using System;

namespace EvenTree
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How large do you want your tree base to be?");
            int initialNumber = int.Parse(Console.ReadLine());
            int baseLength = initialNumber;

            for (int i = 1; i <= initialNumber; i++)
            {
                for (int k = 1; k <= baseLength - 1; k++)
                    Console.Write(" ");
                baseLength--;
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

            Console.ReadLine();


        }
    }
}

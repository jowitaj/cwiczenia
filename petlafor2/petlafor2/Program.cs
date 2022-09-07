using System;
namespace petlafor2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                Console.Write(a * b+" ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
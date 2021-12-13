using System;

namespace Praktikum_Week14
{
    internal class Program
    {
        static void INPUT()
        {
            Console.Write("Input : ");

        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                {
                    INPUT();
                }
                int input = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Output :");
                for (int j = 1; j <= input; j++)
                {
                    int faktor = 0;
                    for (int i = 1; i < j; i++)
                    {
                        if (j % i == 0)
                        {
                            faktor++;
                        }
                    }
                    if (faktor == 2)
                    {
                        Console.Write(j + " ");
                    }
                }
            }
        }
    }
}

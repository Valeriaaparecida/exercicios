using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, i, x, dentro,fora;
            dentro = 0;
            fora = 0;

            N = int.Parse(Console.ReadLine());

            for (i = 1; i <= N; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            } 
            Console.WriteLine(dentro + "in");
            Console.WriteLine(fora + "out");
        }
    }
}
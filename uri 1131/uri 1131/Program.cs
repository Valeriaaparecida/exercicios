using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int vitoriaInter = 0;
            int vitoriaGremio = 0;
            int empate = 0;
            int novoGrenal = 1;
            int grenais = 0;
            string res;

            while (novoGrenal == 1)
            {
                string[] gols = Console.ReadLine().Split(' ');
                int inter = int.Parse(gols[0]);
                int gremio = int.Parse(gols[1]);

                if (inter > gremio)
                {
                    vitoriaInter ++;
                } else if (inter < gremio)
                {
                    vitoriaGremio ++;
                }
                else
                {
                    empate ++;
                }
                grenais ++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());

            }
            if (vitoriaInter > vitoriaGremio)
            {
                res = "Inter venceu mais";
            } else if (vitoriaGremio > vitoriaInter)
            {
                res = "Gremio venceu mais";
            } else
            {
                res = "Houve empate";
            }

            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter: " + vitoriaInter);
            Console.WriteLine("Gremio: " + vitoriaGremio);
            Console.WriteLine("Empates: " + empate);
            Console.WriteLine(res);
        }
    }
}
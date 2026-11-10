using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUGH2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cz = new string[30];
            string[] eng = new string[30];
            int[] pocetDobre = new int[30];
            cz = VratCzSlovicka();
            eng = VratEngSlovicka();

            Console.WriteLine("Zadejte, kolikrát chcete zkoušet:");
            int pocet = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 0; i < pocet; i++)
            {
                int nahodne = rnd.Next(0, 5); // 0 až 4, protože máme zatím jen 5 slov

                Console.WriteLine("Přelož slovo: " + cz[nahodne]);
                string odpoved = Console.ReadLine();

                if (odpoved == eng[nahodne])
                {
                    Console.WriteLine("Správně!");
                    pocetDobre[nahodne]++;
                }
                else
                {
                    Console.WriteLine("Špatně, má být: " + eng[nahodne]);
                }
            }

            Console.ReadLine();
        }

        static string[] VratCzSlovicka()
        {
            string[] cz = new string[30];
            cz[0] = "pes";
            cz[1] = "kocka";
            cz[2] = "králík";
            cz[3] = "lev";
            cz[4] = "kráva";
            return cz;
        }

        static string[] VratEngSlovicka()
        {
            string[] eng = new string[30];
            eng[0] = "dog";
            eng[1] = "cat";
            eng[2] = "rabbit";
            eng[3] = "lion";
            eng[4] = "cow";
            return eng;
        }
    }
}
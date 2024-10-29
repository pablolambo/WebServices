using BiblioteczkaUslugaWCF;
using System;
using System.Threading.Tasks;

namespace App2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            KontekstBiblioteczkiClient client = new KontekstBiblioteczkiClient();
            var ksiazki = await client.PobierzWszystkieAsync();

            foreach (var ksiazka in ksiazki)
            {
                Console.WriteLine(ksiazka.Tytul);
            }

            var ksiazki = await client.();

            Console.WriteLine("Get by id = 1: " + );
        }
    }
}

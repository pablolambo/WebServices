using System;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            UsługaSieciowa.WebServiceSoapClient serwis = new UsługaSieciowa.WebServiceSoapClient(UsługaSieciowa.WebServiceSoapClient.EndpointConfiguration.WebServiceSoap);
            UsługaSieciowa.FunkcjaSkrotuResponse wynik = await serwis.FunkcjaSkrotuAsync("Text");
            string wynikBody = wynik.Body.FunkcjaSkrotuResult;

            Console.WriteLine("Wynik funkcji skrótu: " + wynikBody);
        }
    }
}


using System;

namespace Encapsulamento
{

    public class AmigoProximo
    {
        public readonly SubCelebridade amigo = new SubCelebridade();
        public void MeusAcessos()
        {
            Console.WriteLine("AmigoPróximo...");

            Console.WriteLine(amigo.InfoPublica);
            // Console.WriteLine(amigo.CorDosOlhos);
            Console.WriteLine(amigo.NumeroCelular);
            Console.WriteLine(amigo.JeitoDeFalar);
            // Console.WriteLine(amigo.SegredoFamilia);
            // Console.WriteLine(amigo.UsaMuitoPhotoshop);
        }
    }
}
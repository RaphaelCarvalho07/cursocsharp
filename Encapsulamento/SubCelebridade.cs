using System;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // Herança
        protected string CorDosOlhos = "Verde";

        // Mesmo projeto (Assembly)
        internal ulong NumeroCelular = 5511999999999;

        // Herança ou Mesmo Projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // Mesma Classe ou Herança no mesmo projeto (C# >= 7.2)
        private protected string SegredoFamilia = "Bla Bla";

        // Private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
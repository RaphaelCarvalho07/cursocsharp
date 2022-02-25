using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoFulano);
            Console.WriteLine($"O tamanho da string de apresentação do {fulano.Nome} é: {apresentacaoFulano.Length}");
        }
    }
}
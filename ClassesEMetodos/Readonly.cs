// Readonly permite que, durante o tempo de execução, seja setado um valor imutável para um atributo no construtor do objeto (instância)
// Uma vez que o objeto é criado, este atributo torna-se imutável.
using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return String.Format($"{Nascimento.Day}/{Nascimento.Month}/{Nascimento.Year}");
        }
    }

    class Readonly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente(nome: "Ana Silva", nascimento: new DateTime(year: 1987, month: 5, day: 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}
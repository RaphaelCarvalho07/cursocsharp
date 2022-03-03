/* 
Métodos estáticos pertencem à classe e não ao objeto (instância). Deve ser acessado pela classe. Eles tem apenas uma cópia e é compartilhada por todos
que tem acesso a este membro.

Membros de instância ou de objeto, pertencem à instância, ou seja, podem ser alterados individualmente e cada objeto tem seu próprio atributo
 */

using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
            };

            Produto.Desconto = 0.5;
            Console.WriteLine($"Preço com desconto produto 1: {produto1.CalcularDesconto()}");
            Console.WriteLine($"Preço com desconto produto 2: {produto2.CalcularDesconto()}");

            Produto.Desconto = 0.02;
            Console.WriteLine($"Preço com desconto produto 1: {produto1.CalcularDesconto()}");
            Console.WriteLine($"Preço com desconto produto 2: {produto2.CalcularDesconto()}");
        }
    }
}
using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar() {
            Console.Write("Qual é seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine()); // O Console.Readline sempre recebe o dado como string
                                                       // é preciso converter com parse para se tornar um int ou double 
            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture); // O InvariantCulture permite usar sempre o ponto (.) como separador decimal.
                                               // sem essa função, ele vai se basear nas configurações da máquina,
                                               // no Brasil, por exemplo, o separdor é com vírgula (,)
            Console.WriteLine($"{nome} {idade} R${salario}");
        }

    }
} 
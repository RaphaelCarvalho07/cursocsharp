using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {

        public static void Executar()
        {
            /* 
            As três partes do FOR são: Declaração da variável de controle + Expressão(condição) + incremento da variável de controle
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"O valor de i é {i}.");
            } 
            */

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.Write($"Informe a nota do aluno {i}: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            /* Condição se tamanhoTurma é maior que zero, para fazer a média corretamente, precisa ser maior que 0. 
               Se esta condição for verdadeira, ele faz a divisão do somatório, pelo tamanho da turma e popula a variável media
               do contrário, ele popula a variável com 0
            */
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine($"Média da turma: {media}");
        }
    }
}
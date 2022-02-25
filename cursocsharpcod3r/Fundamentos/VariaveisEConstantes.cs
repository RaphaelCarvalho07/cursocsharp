using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{

    class VariaveisEConstantes
    {
        public static void Executar() {
            // área da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            /*
             Existem os tipos numérios byte, short, int e long
               Inteiros
               byte = 8bits
               Short = 2 bytes
               int = 4 bytes 
               long = 8 bytes
               
               Reais 
               float = 4bytes
               Double = 8 bytes
               Por convenção, usaremos DOUBLE para ponto flutuante e INT para inteiros

               Textuais
               char = apenas um caracter
               string = cadeia de caracteres
            */
            byte idade = 45;
            Console.WriteLine("Idade " + idade);
            /*
            O SBYTE é quem vai apresentar valores negativos, pois ele é um tipo que tem sinal.
            Ele tem um range entre positivos e negativos. Significa SignedByte, ou seja, com sinal
            */
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            // int nativamente é com sinal (negativo)
            int menorValorInt = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt);

            // uint significa unsigned, ou seja sem sinal (positivo)
            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos reais!
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
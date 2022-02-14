using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Formato uma casa decimal
            Console.WriteLine(valor.ToString("C")); // Formato Currency
            Console.WriteLine(valor.ToString("P")); // Formato percentual
            Console.WriteLine(valor.ToString("#.##")); // formato casa decimal mais específico

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura)); // muda a referência cultural da máquina local, como moeda, idioma, casa decimal, etc

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // define quantos dígitos esperar no resultado final, completado com o 0 as casas faltantes
        }
    }
}
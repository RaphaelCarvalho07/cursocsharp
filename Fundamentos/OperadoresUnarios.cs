using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // inverte valor da variável entre positivo e negativo;
            Console.WriteLine(!booleano); // negação lógica - inverte o resultado booleano;

            numero1++; // incrementa variavel em si mesmo + um;
            Console.WriteLine(numero1);

            --numero1; // decrementa variável em si mesmo - um;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); // tem maior precedência quando o sinal é passado à frente da variável
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
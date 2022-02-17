// Assinatura de um método deve ser única dentro da mesma classe. Ela é composta pelo nome do método e seus parâmetros
using System;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            return a / b;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var CalculadoraComum = new CalculadoraComum();
            var resultado = CalculadoraComum.Somar(5, 5);
            var resultado2 = CalculadoraComum.Dividir(10, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(CalculadoraComum.Subtrair(2, 7));
            Console.WriteLine(CalculadoraComum.Multiplicar(10, 10));
            Console.WriteLine(resultado2);
        }
    }
}
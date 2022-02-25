/* 
Métodos estáticos pertencem à classe e não ao objeto (instância). Deve ser acessado pela classe. Eles tem apenas uma cópia e é compartilhada por todos
que tem acesso a este membro.

Membros de instância ou de objeto, pertencem à instância, ou seja, podem ser alterados individualmente e cada objeto tem seu próprio atributo
 */

using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // Método de Classe ou Método Estático!!!
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // Método de instância ou Método de Objeto!!!
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine($"Resultado: {resultado}");

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}
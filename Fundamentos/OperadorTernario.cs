/* 
Expressão + Operando 1 + Operando 2
Operador ternário pode ser chamado de Operador Condicional/Atribuição condicional
Dada uma expressão, dependendo do resultado booleano, o operador atribui a um operando, do contrário, atribui a outro operando
Então as três partes do operador ternário são: Uma expressão que retorna Verdadeiro ou Falso, um operando que será atribuido
caso essa expressão retorna True e um segundo operando, que será atribuido caso a expressão retorne False 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 9.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento
            ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
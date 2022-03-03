using System;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano){
            Console.WriteLine($"{dia:D2}/{mes:D2}/{ano}");
        }
        
        public static void Executar()
        {
            Formatar(ano: 1986, dia: 7, mes: 12);
        }
    }
}
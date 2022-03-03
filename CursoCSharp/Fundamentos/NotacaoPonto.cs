using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!")
                .Replace("World!", "Mundo!");

            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);
            /* Notação em nulo causa erro. Use navegação segura,
            representado por sinal ? para conferir o conteúdo.
            Isso é chamado de "Navegação Segura"
            */
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
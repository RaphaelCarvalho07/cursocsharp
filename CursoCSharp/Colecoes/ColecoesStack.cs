using System;
using System.Collections;

namespace CursoCSharp.Colecoes {

    class ColecoesStack {
        public static void Executar() {
            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push("Letra A");
            pilha.Push(true);
            pilha.Push(3.14f);
            
            foreach (var item in pilha)
            {
                Console.Write($"Item na pilha: {item}, ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.Write($"Item na pilha: {item}, ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
        }
    }
}
using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16); // valor gerado será entre 1 e 15.
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) //Unário (!) com false, com && sempre dá false 
            {
                Console.Write("Digite seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Número encontrado em {tentativas} tentativa(s)");
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor...Tente novamente!");
                    Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
                }
                else
                {
                    Console.WriteLine("Maior...Tente novamente!");
                    Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
                }
            }
        }
    }
}
using System;
/* 
Três características importantes de um array:
1 - Arrays são estruturas homogêneas, ou seja, só pode ser armazenados valores do mesmo tipo (string, int, double, etc)
2 - Arrays são estruturas estáticas. Ela tem limite que é determinado na declaração da mesma. Para aumentar o tamanho, é necessário
criar outra variável(pode ser com o mesmo nome), determinando que esta nova, apesar do mesmo nome, terá mais posições do que a anterior.
 3 - Arrays são indexados, ou seja, são acessados por meio de índice(posicionamento). Essa contagem começa com 0.
 Logo, se você tem um array com 5 posições, você deve contar da seguinte forma: 0 - 1 - 2 - 3 - 4, ou seja, começando do 0 e indo até o 4.
 */

namespace CursoCSharp.Colecoes {

    class Array {

        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };
            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            // for (int i = 0; i < notas.Length; i++)
            // {
            //     somatorio += notas[i];
            // }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y', };
            string palavra = new string(letras);
            Console.WriteLine(palavra); 
        }
    }
}
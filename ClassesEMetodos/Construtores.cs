using System;

namespace CursoCSharp.ClassesEMetodos
{

    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro()
        {

        }
    }

    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro(); // Construtur padrão: Quando não se cria 1 construtor, recebe um construtor padrão
            carro1.Modelo = "325i";  // Tem o mesmo nome da classe e Não recebe parâmetro.
            carro1.Fabricante = "BMW";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante}, {carro1.Modelo}, {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Fabricante}, {carro2.Modelo}, {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine($"{carro3.Fabricante}, {carro3.Modelo}, {carro3.Ano}");
        }
    }
}
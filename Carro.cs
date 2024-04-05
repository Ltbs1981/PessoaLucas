using System;
using System.Collections.Generic;
using System.Text;

namespace PessoaLucas
{
    class Carro
    {

        public string  Modelo  { get; set; }
        public string  Cor  { get; set; }
        public int Ano  { get; set; }

        public Carro(string modelo, string cor, int ano)
        {
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
        }

        public void ExibirCarro()
        {
            Console.WriteLine($"{Modelo}\t{Cor}\t{Ano}");
        }
    }
}

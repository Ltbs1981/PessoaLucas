using System;

namespace PessoaLucas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Lucas", 33, 1.50);
            p1.Apresentar();
            Carro c1 = new Carro("Fiat","Vermelho", 2008);
            c1.ExibirCarro();

        }
    }
}
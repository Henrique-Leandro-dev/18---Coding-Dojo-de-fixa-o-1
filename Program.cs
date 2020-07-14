using System;

namespace Aula18_dojo
{
    class Program
    {
        static void Main(string[] args)
        {
     Jogador fred = new Jogador();

            System.Console.WriteLine("Qual o nome do jogador?");
            fred.Nome = Console.ReadLine();
            Console.Clear();
            
            System.Console.WriteLine("Qual a nacionalidade?");
            fred.Nacionalidade = Console.ReadLine();
            Console.Clear();

            System.Console.WriteLine($"Qual o peso do {fred.Nome} atual?");
            fred.Peso = float.Parse(Console.ReadLine());
            Console.Clear();

            System.Console.WriteLine($"Qual a altura do {fred.Nome}?");
            fred.Altura = float.Parse(Console.ReadLine());
            Console.Clear();

            System.Console.WriteLine($"Qual a data de nascimento do {fred.Nome} (dia/mês/ano)?");
            fred.DataDeNascimento = DateTime.Parse(Console.ReadLine());
            Console.Clear();
            
            System.Console.WriteLine($"Em qual posição o {fred.Nome} joga (escolha somente uma)?\nATA = atacante | MC = meio-campista | DEF = defensor");
            fred.Posicao = Console.ReadLine();
            Console.Clear();

            System.Console.WriteLine(fred.CalcularIdade());
            System.Console.WriteLine(fred.VerificarAposentadoria(fred.Posicao, fred.Nome));
        }
    }
}
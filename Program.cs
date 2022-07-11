using System;
namespace Precificador
{
    class LojaIfood
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o valor do produto");
            var valor = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem desejada ex 50% = 50");
            var porcentagem = int.Parse(Console.ReadLine());
            Calcula(valor, porcentagem);
        }

        static void Calcula(decimal valor, int porcentagem)
        {
            //calculo baseado o ifood
            var calculo1 = (valor * porcentagem);
            var calculo2 = (100 - porcentagem);
            var resultado = (calculo1 / calculo2) + valor;
            Console.WriteLine($"Valor sem arredondamento {resultado}");
            Console.WriteLine($"Valor a ser cobrado {Math.Round(resultado)}");         
        }
    }
}
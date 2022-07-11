using System;
namespace Precificador
{
    class Menus
    {
        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor do produto");
            var valor = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem desejada ex 50% = 50");
            var porcentagem = int.Parse(Console.ReadLine());
            Calculos.Calcula(valor, porcentagem);
        }
    }
}
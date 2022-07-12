using System;
namespace Precificador
{
    class Menus
    {
        public static void MenuPrincipal()
        {      
            Design.CorPrimaria();
            Console.Clear();
            Console.WriteLine("Digite o valor do produto");
            var valor = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem desejada ex 50% = 50");
            var porcentagem = int.Parse(Console.ReadLine());
            Calculos.Calcula(valor, porcentagem);
            MenuVoltar();
        }
        
        public static void MenuVoltar()
        {
            Design.CorPrimaria();
            Console.WriteLine("1 - Deseja voltar?");
            Console.WriteLine("2 - Sair");
            var opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:MenuPrincipal(); break;
                case 2: System.Environment.Exit(0);break;
                default:MenuPrincipal();break;
            }
        }
    }
}
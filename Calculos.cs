using System;
namespace Precificador
{
    public class Calculos
    {
        public static void Calcula(decimal valor, int porcentagem)
        {
            Design.CorSecundaria();
            Design.Linha(40);
            //calculo baseado no ifood
            var calculo1 = (valor * porcentagem);
            var calculo2 = (100 - porcentagem);
            var resultado = (calculo1 / calculo2) + valor;
            Console.WriteLine($"Valor sem arredondamento {resultado}");
            Console.WriteLine($"Valor sugerido {Math.Round(resultado)}");
            Design.Linha(40);         
        }
    }
}
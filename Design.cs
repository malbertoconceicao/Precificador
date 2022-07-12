using System;
namespace Precificador
{
    public class Design 
    {
        public static void Linha(int traco)
        {
            Console.Write("+");
            for (int i = 0; i < traco; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
        public static void CorPrimaria()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }

        public static void CorSecundaria()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
    }
}
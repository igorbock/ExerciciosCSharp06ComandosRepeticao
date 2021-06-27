using static System.Console;

namespace ExerciciosCSharp06ComandosRepeticao
{
    public class Menu
    {
        public Menu()
        {
            WriteLine("Escolha o número do exercício ou digite \"SAIR\" para encerrar o programa.");
            WriteLine("1 - Multiplos de 3");
            WriteLine("2 - 100 com For, Do e Do While");
        }
        public static void Voltar()
        {
            WriteLine("\n\nAperte \"ENTER\" para voltar...");
        }
        
    }
}

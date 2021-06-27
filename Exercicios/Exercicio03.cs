using static System.Console;

namespace Exercicios
{
    public class Exercicio03
    {
        public static void ContagemRegressiva()
        {
            int contador = 10;
            while(contador >= 0)
            {
                WriteLine(contador);
                if (contador.Equals(0))
                {
                    WriteLine("FIM");
                }
                contador--;
            }
        }
    }
}

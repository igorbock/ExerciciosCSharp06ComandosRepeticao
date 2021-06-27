using static System.Console;

namespace Exercicios
{
    public class Exercicio2
    {
        public void UsandoFor()
        {
            for(int i = 1; i <= 100; i++)
            {
                WriteLine(i);
            }
        }
        public void UsandoWhile()
        {
            int i = 1;
            while(i <= 100)
            {
                WriteLine(i);
                i++;
            }
        }
        public void UsandoDoWhile()
        {
            int i = 1;
            do
            {
                WriteLine(i);
                i++;
            } while (i <= 100);
        }
    }
}

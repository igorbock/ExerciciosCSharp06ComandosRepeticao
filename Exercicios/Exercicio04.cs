using static System.Console;

namespace Exercicios
{
    public class Exercicio04
    {
        private int numero { get; set; }
        public void Incremento1000()
        {
            for(numero = 0; numero <= 100000; numero += 1000)
            {
                WriteLine(numero);
            }
        }
    }
}

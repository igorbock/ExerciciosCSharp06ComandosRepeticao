using static System.Console;
using static ExerciciosCSharp06ComandosRepeticao.Menu;
using static Exercicios.Exercicio01;
using Exercicios;

namespace ExerciciosCSharp06ComandosRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                new Menu();
                opcao = ReadLine();

                if(opcao.Equals("1"))
                {
                    Clear();
                    WriteLine("Exercício 1");
                    WriteLine(Multiplos3());
                    Voltar();
                    ReadLine();
                }
                if (opcao.Equals("2"))
                {
                    Clear();
                    new Exercicio2().UsandoFor();
                    new Exercicio2().UsandoWhile();
                    new Exercicio2().UsandoDoWhile();
                    Voltar();
                    ReadLine();
                }
                Clear();
            }
            while (!opcao.ToUpper().Equals("SAIR"));
            
        }
    }
}

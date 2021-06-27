using static System.Console;
using static ExerciciosCSharp06ComandosRepeticao.Menu;
using static Exercicios.Exercicio01;
using static Exercicios.Exercicio03;
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
                if (opcao.Equals("3"))
                {
                    Clear();
                    ContagemRegressiva();
                    Voltar();
                    ReadLine();
                }
                if (opcao.Equals("4"))
                {
                    Clear();
                    new Exercicio04().Incremento1000();
                    Voltar();
                    ReadLine();
                }
                if (opcao.Equals("5"))
                {
                    Clear();
                    new Exercicio05().Soma10Numeros();
                    Voltar();
                    ReadLine();
                }
                Clear();
            }
            while (!opcao.ToUpper().Equals("SAIR"));
            
        }
    }
}

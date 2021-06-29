using static System.Console;
using BibliotecaExerciciosException;

namespace Exercicios
{
    public class Exercicio09
    {
        private int Inteiro { get; set; }
        public void NImpares()
        {
            string Valor;
            try
            {
                WriteLine("Digite um número inteiro: ");
                Valor = ReadLine();
                if(int.TryParse(Valor, out int result) && result > 0)
                {
                    Clear();
                    Inteiro = result;
                    WriteLine($"Número impares até {Inteiro}: ");
                    for(int i = 1; i <= Inteiro; i++)
                    {
                        if(i % 2 != 0)
                        {
                            WriteLine(i);
                        }
                    }
                }
                else
                {
                    throw new ExercicioException($"O parametro {nameof(Inteiro)} não foi preenchido ou o valor não é um inteiro positivo. \"{Valor}\" não é válido.");
                }
            }
            catch(ExercicioException erro)
            {
                WriteLine($"Um erro aconteceu: {erro.Message}");
            }
        }
    }
}

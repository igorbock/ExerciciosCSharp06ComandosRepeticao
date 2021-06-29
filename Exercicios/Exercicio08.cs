using static System.Console;
using BibliotecaExerciciosException;

namespace Exercicios
{
    public class Exercicio08
    {
        private double[] Numeros = new double[10];
        private double MenorValor { get; set; } = double.MaxValue;
        private double MaiorValor { get; set; } = double.MinValue;
        private int Contador { get; set; } = 1;
        public void MaiorMenorValor()
        {
            string Valor;
            try
            {
                foreach(int i in Numeros)
                {
                    WriteLine($"Digite o {Contador}º número: ");
                    Valor = ReadLine();
                    if(double.TryParse(Valor, out double result))
                    {
                        Numeros[i] = result;
                        Contador++;
                        if(MenorValor > Numeros[i])
                        {
                            MenorValor = Numeros[i];
                        }
                        if(MaiorValor < Numeros[i])
                        {
                            MaiorValor = Numeros[i];
                        }
                    }
                    else
                    {
                        throw new ExercicioException($"O parâmetro {nameof(Numeros)}[{Contador}] não foi preenchido ou seu valor não é numerico. \"{Valor}\" não é um valor válido.");
                    }
                }
                Clear();
                WriteLine($"O maior valor é: {MaiorValor}");
                WriteLine($"O menor valor e: {MenorValor}");
            }
            catch(ExercicioException erro)
            {
                WriteLine($"Um erro aconteceu: {erro.Message}");
            }
        }
    }
}

using static System.Console;
using BibliotecaExerciciosException;

namespace Exercicios
{
    public class Exercicio06
    {
        private int[] _numeros = new int[10];
        private int Contador { get; set; } = 1;
        private int Total { get; set; } = 0;
        public void Media10Inteiros()
        {
            try
            {
                foreach(int i in _numeros)
                {
                    WriteLine($"Digite o {Contador}º número: ");
                    if(int.TryParse(ReadLine(), out int result))
                    {
                        _numeros[i] = result;
                        Contador++;
                        Total += _numeros[i];
                    }
                    else
                    {
                        throw new ExercicioException($"O valor {result} não é válido.");
                    }
                    Clear();
                }
                
                WriteLine($"\n\nA média dos inteiros: {Total / _numeros.Length}");
            }
            catch(ExercicioException erro)
            {
                WriteLine($"Um erro aconteceu: {erro.Message}");
            }
        }
    }
}

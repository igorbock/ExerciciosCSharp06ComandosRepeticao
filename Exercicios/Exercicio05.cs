using System;
using static System.Console;

namespace Exercicios
{
    public class Exercicio05
    {
        public void Soma10Numeros()
        {
            double[] numeros = new double[10];
            int contador = 1;
            double resultado = 0;
            foreach (int num in numeros)
            {
                WriteLine($"Digite o valor do {contador}º número: ");
                try
                {
                    if(double.TryParse(ReadLine(), out double result) && result >= double.MinValue && result <= double.MaxValue)
                    {
                        numeros[num] = result;
                        contador += 1;
                        resultado += numeros[num];
                    }
                    else
                    {
                        throw new Exception();
                    }
                    Clear();
                }
                catch(Exception erro)
                {
                    WriteLine($"Um erro aconteceu: {erro}");
                    break;
                }
            }
            WriteLine($"O resultado da soma dos 10 números é: {resultado}");
        }
    }
}

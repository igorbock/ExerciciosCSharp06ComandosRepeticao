﻿using static System.Console;

namespace ExerciciosCSharp06ComandosRepeticao
{
    public class Menu
    {
        public Menu()
        {
            WriteLine("Escolha o número do exercício ou digite \"SAIR\" para encerrar o programa.");
            WriteLine("1 - Multiplos de 3");
            WriteLine("2 - 100 com For, Do e Do While");
            WriteLine("3 - Contagem regressiva");
            WriteLine("4 - Incremento de 1000 em 1000");
            WriteLine("5 - Soma de 10 números");
            WriteLine("6 - Média de 10 inteiros");
            WriteLine("8 - Encontre o maior e menor valor");
            WriteLine("9 - Números impares até valor X");
        }
        public static void Voltar()
        {
            WriteLine("\n\nAperte \"ENTER\" para voltar...");
        }
        
    }
}

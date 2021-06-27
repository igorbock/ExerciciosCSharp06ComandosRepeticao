namespace Exercicios
{
    public static class Exercicio01
    {
        public static string Multiplos3()
        {
            string multiplos = "";
            for(int i = 1; i <= 5; i++)
            {
                if (i.Equals(5))
                {
                    multiplos += $"{i * 3}";
                }
                else if (i.Equals(4))
                {
                    multiplos += $"{i * 3} e ";
                }
                else
                {
                    multiplos += $"{i * 3}, ";
                }
            }
            return multiplos;
        }
    }
}

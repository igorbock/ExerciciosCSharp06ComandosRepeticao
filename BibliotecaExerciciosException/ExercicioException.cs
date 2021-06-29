using System;

namespace BibliotecaExerciciosException
{
    public class ExercicioException : Exception
    {
        public ExercicioException(string mensagem) : base($"Uma exceção foi lançada: {mensagem}")
        {

        }
    }
}
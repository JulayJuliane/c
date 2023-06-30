using System;

namespace _03ExercícioEscolar
{
    class Program
{
    private static void Main(string[] args)
    {
        // Instanciar objeto da classe Aluno

        Aluno a = new Aluno();
        a.nome = "Denis";
        a.nota1 = 1;
        a.nota2 = 10;
        a.mensagem();
    }
}
}

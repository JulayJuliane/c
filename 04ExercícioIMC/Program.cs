using System;

namespace _04ExercícioIMC
{
    class Program
    {
        private static void Main(string[] args)
        { //instancia um objeto
            Pessoa p = new Pessoa();
            p.peso = 75;
            p.altura = 1.65;
            p.mensagem();
        }
    }
}
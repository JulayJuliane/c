using System;

abstract class Padrao
{
    //método  obrigatório
    public abstract void taxaEmprestimo(double valor);
    
    //método opcional
    public void calcularPoupança(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança R$ "+(valor*taxa));
    }
}
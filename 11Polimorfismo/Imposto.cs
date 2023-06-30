using System;

class Imposto
{
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto padrão do vale alimentação"+ (salario * 0.1));
    }
    public void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do vale transporte R$"+(salario * 0.06));
    }
}
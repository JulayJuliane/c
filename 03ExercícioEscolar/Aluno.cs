using System;

class Aluno
{
    // Atributos
    
    public string nome {get; set; } = "";

    public double nota1, nota2;

    //Média
    public double media()
    {
        return (nota1+nota2)/2;
    }
        // Situação
    public string situação(double media)
    {
    return media >= 7 ? "aprovado" : "reprovado";
    }
    //Mensagem

    public void mensagem()
    {
        //obter média
        double obterMedia = media();

        // obter situação
        string obterSituação = situação(obterMedia);

        //mensagem
        Console.WriteLine( nome +" está " + obterSituação + " com média "+ obterMedia);
    }
}
using System;

class Pessoa
{
    //Atributos
    public double peso, altura;

    //Método
    public double calculo()
    {
        return peso / (altura* altura);    
    }

    public string situação(double imc)
    {
        // String de Retorno
        string retorno;
        if (imc < 18.5) {retorno ="Abaixo do peso";}
        else if (imc < 25) {retorno ="Peso normal";}
        else if (imc < 30) {retorno ="Acima do Peso";}
        else if (imc < 35) {retorno ="Obesidade I";}
        else if (imc < 40) {retorno ="Obesidade II";}
        else {retorno ="Obesidade III";}
        return retorno;
    }

    public void mensagem (){
        //obter calculo
        double obterCalculo = calculo();

        // obter situação
        string obterSituação = situação(obterCalculo);

        Console.WriteLine("Seu IMC é "+ obterCalculo);
        Console.WriteLine("Sua situação é "+ obterSituação);

    }

}
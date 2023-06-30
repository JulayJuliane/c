using System;

class Pessoa
{
    //Atributos

    public string nome {get; set; } = "";

    public int idade {get; set; } = 0;

    public Pessoa(string nome, int idade){
        this.nome = nome;
        this.idade = idade; 
    }
    
    public void mensagem()
    {
        Console.WriteLine("Olá "+ nome + ", você tem "+ idade +" anos.");
    }
}

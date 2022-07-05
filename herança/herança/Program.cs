using System;
public class Veiculo //classe BASE (pai)
{
    public int rodas;
    public int velMax;
    private bool ligado;

    public void ligar()
    {
        ligado = true;
    }
    public void desligar()
    {
        ligado = false;
    }

    public string getLigado()
    {
        if (ligado)
        {
            return "Sim";
        }
        else
            return "Não";
    }

}
class carro:Veiculo //herdar a classe
{
    public string nome;
    public string cor;
    public carro(string nome, string cor)
    {
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}
class herança
{
    static void Main()
    {
        carro c1 = new carro("Uno","Prata");

        Console.WriteLine("Cor.................: {0}", c1.cor);
        Console.WriteLine("Nome................: {0}", c1.nome);
        Console.WriteLine("Rodas...............: {0}", c1.rodas);
        Console.WriteLine("Velocidade Maxima...: {0}", c1.velMax);
        Console.WriteLine("Veiculo ligado......: {0}", c1.getLigado());
    }
}
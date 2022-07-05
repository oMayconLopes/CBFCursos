using System;
class Veiculo //clase BASE
{
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax)
    {
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }
    public int  getVelMax()
    {
        return velMax;
    }

}

class Carro : Veiculo // Classe derivada de veículo
{
    public string nome;
    public Carro(string nome, int vMax):base(vMax)
    {
        this.nome = nome;
        ligado = true;
    }
    public bool getLigado()
    {
        return ligado;
    }
}

class protect
{
    static void Main()
    {
        Carro carro = new Carro("Uno", 120);

        Console.WriteLine("Nome..............: {0}", carro.nome);
        Console.WriteLine("Velocidade Max....: {0}", carro.getVelMax());
        Console.WriteLine("Ligado?...........: {0}", carro.getLigado());
    }
}
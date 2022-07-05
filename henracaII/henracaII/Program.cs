using System;
public class Veiculo //classe BASE (pai)
{
    private int rodas;
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

    public Veiculo(int rodas)
    {
        this.rodas = rodas;
    }

    public string getLigado()
    {
        return ligado ? "Sim" : "Não";
    }
    public int getRodas()
    {
        return rodas;
    }

    public void setRodas(int rodas)
    {
        if(rodas < 0)
        {
            this.rodas = 0;
        }else if(rodas > 40)
        {
            this.rodas = 40;
        }
        else
        {
            this.rodas = rodas;
        }
    }
}
public class carro : Veiculo //herdar a classe
{
    public string nome;
    public string cor;
    public carro(string nome, string cor) : base(4)
    {
        desligar();
        
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}
public class carroCombate : carro
{
    public int municao;

    public carroCombate() : base("Carro de Combate", "Verde")
    {
        municao = 100;
        setRodas(6);
    }
}

class herança
{
    static void Main()
    {
        carro c1 = new carro("Uno", "Prata");

        c1.ligar();

        Console.WriteLine("Cor.................: {0}", c1.cor);
        Console.WriteLine("Nome................: {0}", c1.nome);
        Console.WriteLine("Rodas...............: {0}", c1.getRodas());
        Console.WriteLine("Velocidade Maxima...: {0}", c1.velMax);
        Console.WriteLine("Veiculo ligado......: {0}", c1.getLigado());

        carroCombate cCombate = new carroCombate();

        cCombate.ligar();

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Cor.................: {0}", cCombate.cor);
        Console.WriteLine("Nome................: {0}", cCombate.nome);
        Console.WriteLine("Rodas...............: {0}", cCombate.getRodas());
        Console.WriteLine("Velocidade Maxima...: {0}", cCombate.velMax);
        Console.WriteLine("Veiculo ligado......: {0}", cCombate.getLigado());
        Console.WriteLine("Municao.............: {0}", cCombate.municao);

    }
}
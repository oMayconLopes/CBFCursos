using System;
class Jogador
{
    private int energia;
    private string nome;

    public Jogador(string nome) //Construtor
    {
        this.nome = nome;
        energia = 100;
    }

    public int getEnergia() //Para acessar algo Private
    {
        return energia;
    }

    public string getNome()
    {
        return nome;
    }
    public void setEnergia(int e)
    {
        if(e < 0)
        {
            if(energia+e < 0) //por conta do - com - = +
            {
                energia=0;
            }else
            {
                energia += e; //por conta do - com - = +
            }
        }else if(e > 0)
        {
            if(energia+e > 100)
            {
                energia = 100;
            }else
            {
                energia += e;
            }
        }
    }
}
class publicPrivate
{
    static void Main()
    {
        Jogador j1 = new Jogador("Maycon");

        j1.setEnergia(-150);

        Console.WriteLine("Nome.....: {0}", j1.getNome());
        Console.WriteLine("Energia..: {0}", j1.getEnergia());
    }
}
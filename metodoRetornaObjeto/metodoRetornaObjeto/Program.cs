using System;
class Galinha
{
    private string nomeGalinha;
    private int numOvo;

    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }
    public Ovo Botar() //visibilidade, tipo retorno e metodo
    {
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}
class galinhaOvos
{
    static void ovoGalinha()
    {
        Console.Write("Informe a quantidade de Galinhas");
        int qtd = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < qtd; i++)
        {
            
        }
        

    }
}
class Ovo
{
    private int numOvo;
    private string minhaGalinha;

    public Ovo(int numOvo, string minhaGalinha)
    {
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("Ovo criado - {0} - {1}", this.numOvo, this.minhaGalinha);        
    }
}
class main
{
    static void Main()
    {
        Galinha g1 = new Galinha("A");


        g1.Botar();
        
    }

}
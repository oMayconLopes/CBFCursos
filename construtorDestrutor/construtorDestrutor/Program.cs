using System;
public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    ~Jogador()
    {
        Console.WriteLine("Jogador {0} Destruido", nome);
    }    
}
class construtorDestrutor
{
    static void Main()
    {
        string name;
        Console.Write("Digite o nome do jogador 1: ");
        name = Console.ReadLine();
            
        Jogador j1 = new Jogador(name);
        //Jogador j2 = new Jogador("Nome 2");

        j1.energia = 75;

        Console.WriteLine("Energia do {1} é {0}", j1.energia, j1.nome);
       // Console.WriteLine("Energia do {1} é {0}", j2.energia, j2.nome);
    }
}
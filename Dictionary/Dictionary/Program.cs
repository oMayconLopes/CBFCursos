using System;
using System.Collections.Generic;
class colecao
{
    static void Main()
    {
        Dictionary <int,string> veiculos = new Dictionary<int,string>();  //tipo para chave e tipo para valor

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Bike");

        //veiculos.Clear();

        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);

        veiculos.Remove(20);

        veiculos[15] = "Bicicleta";

        string valor = "Bicicleta";
        if (veiculos.ContainsValue(valor))
        {
            Console.WriteLine("O valor {0} está na coleção", valor);
        }
        else
        {
            Console.WriteLine("O valor {0} não está na coleção", valor);
        }

        Console.WriteLine("---------------");
        
        int chave = 20;
        if(veiculos.ContainsKey(chave))
        {
            Console.WriteLine("A chave {0} está na coleção", chave);
        }else
        {
            Console.WriteLine("A chave {0} não está na coleção", chave);
        }

        Console.WriteLine("---------------");

        Dictionary<int, String>.ValueCollection valores = veiculos.Values;

        foreach (string v in valores)
            Console.WriteLine(v);

        Console.WriteLine("---------------");

        foreach (KeyValuePair<int, string> v in veiculos) //KeyValuePair -> Converter
            Console.WriteLine(v.Value);
    }
}
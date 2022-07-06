using System;
using System.Collections.Generic;
class Queue
{
    static void Main()
    {
        //string[] vs = { "Carro", "Moto", "Navio", "Bike" }; 
        // Queue<string> veiculos = new Queue<string>(vs);

        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        string v = "Avião";
        if(veiculos.Contains(v))
        {
            Console.WriteLine("Veiculo {0} encontrado", v);
        }else
        {
            Console.WriteLine("Veiculo não encontrado.");
        }

        Console.WriteLine("Tamanho fila: {0}", veiculos.Count);
        Console.WriteLine("Primeiro veiculo {0}", veiculos.Dequeue());
        Console.WriteLine("Tamanho fila: {0}", veiculos.Count);
        Console.WriteLine("Primeiro veiculo Peek {0}\n\n", veiculos.Peek());
        //Console.WriteLine("Tamanho fila: {0}", veiculos.Count);

        foreach (string vs in veiculos)
            Console.WriteLine(vs);
            

    }
}
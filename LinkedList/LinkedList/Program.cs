using System;
using System.Collections.Generic;
class LinkedList
{
    static void Main()
    {
        LinkedList<string> transportes = new LinkedList<string>();

        transportes.AddFirst("Carro");
        transportes.AddFirst("Navio");
        transportes.AddFirst("Avião");
        transportes.AddFirst("Motocicleta");

        foreach (string t in transportes)
            Console.WriteLine(t);

    }
}
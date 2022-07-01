using System;
class metodo
{
    static void Main()
    {
        metodoChamado();

        int v1, v2;
        /*
         soma(10, 50);
        v1 = int.Parse(Console.ReadLine());
        v2 = Convert.ToInt32(Console.ReadLine());

        soma(v1, v2);
        */

        v1 = int.Parse(Console.ReadLine());
        v2 = int.Parse(Console.ReadLine());

        Console.WriteLine(multiplicacao(v1,v2));
    }

    static void metodoChamado()
    {
        Console.WriteLine("Metodo que foi chamado");
        Console.WriteLine("Curso de C#");
    }

    static void soma(float n1, float n2)
    {
        float res = n1 + n2;
        Console.WriteLine("A soma de {0} e {1} = {2}", n1, n2, res);
    }

    static int multiplicacao(int n1, int n2)
    {
        int res = n1 * n2;
        return res;
    }

}
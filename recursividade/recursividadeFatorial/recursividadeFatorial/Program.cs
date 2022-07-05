using System;
class Recursividade
{
    public int soma(params int[] n) //sobre carga - mesmo nome com parametros diferentes.
    {
        int s = 0;
        for (int i = 0; i < n.Length; i++)
            s += n[i];
        return s;
    }
    public double soma(params double[] n) //sobre carga - mesmo nome com parametros diferentes.
    {
        double s = 0;
        for (int i = 0; i < n.Length; i++)
            s += n[i];
        return s;
    }

    public int fat(int n)
    {
        int res;
        if (n <= 1)
        {
            res = 1;
        }
        else
        {
            res = n * fat(n - 1);
        }
        return res;
    }

}
class main
{
    static void Main()
    {
        Recursividade calc = new Recursividade();
        var somatorio = calc.fat(10);
        Console.WriteLine(somatorio);


    }
}
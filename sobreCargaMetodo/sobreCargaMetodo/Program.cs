using System;
class Calc
{
    public int soma(params int[]n) //sobre carga - mesmo nome com parametros diferentes.
    {
        int s = 0;
        for(int i = 0; i < n.Length; i++)
            s += n[i];
        return s;
    }
    public double soma(params double[]n) //sobre carga - mesmo nome com parametros diferentes.
    {
        double s = 0;
        for (int i = 0; i < n.Length; i++)
            s+=n[i];
        return s;
    }
}
class main
{
    static void Main()
    {
        Calc calc = new Calc();
        var somatorio = calc.soma(7.6, 9, 10);
        Console.WriteLine(somatorio);
    }
}
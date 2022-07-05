using System;
public delegate int Operacao(int n1, int n2);
class Mat
{
    public static int soma(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
}
class main
{
    private static Operacao soma;

    static void Main()
    {
        int resultado;

        Operacao op = new Operacao(Mat.soma);

        resultado = op(10, 60);

        Console.WriteLine(resultado);

        Operacao op1 = new Operacao(Mat.multiplicar);
        resultado = op1(10, 50);

        Console.WriteLine(resultado);
    }
}
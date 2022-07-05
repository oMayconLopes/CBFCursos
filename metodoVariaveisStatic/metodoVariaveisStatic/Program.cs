using System;
class Mat
{
    public static double pi = 3.14;

    public static int dobro(int n)
    {
        return n * 2;
    }
}
class main
{
    static void Main()
    {
        double vPi = Mat.pi;

        Console.WriteLine(vPi);

        int num = 10;

        Console.WriteLine(Mat.dobro(num));
    }
}
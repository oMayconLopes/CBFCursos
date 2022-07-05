using System;
class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe Base");
    }
}
class derivada1:Base
{
    public derivada1()
    {
        Console.WriteLine("Construtor da classe derivada 1");
    }
}
class derivada2 : derivada1
{
    public derivada2()
    {
        Console.WriteLine("Construtor da classe derivada 2");
    }
}
class henraçaOrdemConstrucao
{
    static void Main()
    {
        derivada2 derivada2 = new derivada2();

    }
}
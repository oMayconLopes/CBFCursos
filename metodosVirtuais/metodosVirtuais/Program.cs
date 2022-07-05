using System;
class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe Base");
    }
    virtual public void info()
    {
        Console.WriteLine("Base");
    }
}
class derivada1 : Base
{
    public derivada1()
    {
        Console.WriteLine("Construtor da classe derivada 1");
    }
    override public void info()
    {
        Console.WriteLine("Derivada 1");
    }
}
class derivada2 : derivada1
{
    public derivada2()
    {
        Console.WriteLine("Construtor da classe derivada 2");
    }
    override public void info()
    {
        Console.WriteLine("Derivada 2");
    }
}
class henraçaOrdemConstrucao
{
    static void Main()
    {
        Base Ref = new Base();
        derivada1 derivada1 = new derivada1();
        derivada2 derivada2 = new derivada2();
        Ref = derivada;

        Ref.info();

        derivada1.info();
        derivada2.info();

    }
}
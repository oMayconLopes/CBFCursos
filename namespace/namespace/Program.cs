using System;
namespace Calc1
{
    class Area
    {
        public static float Quadrado(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou Altura não podem ser igual a ZERO");
            }
            return bas * alt;
        }
    }
}
namespace Calc2
{
    class Area
    {
        public static float Quadrado(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou Altura não podem ser igual a ZERO");
            }
            return bas * alt;
        }
    }
}

class main
{
    static void Main()
    {
        float area = 0;

        try
        {
            area = Calc1.Area.Quadrado(10, 2);
            Console.WriteLine("Area do quadrado: {0}", area);
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro.");
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Finally");
        }

    }
}
using System;
class typecast
{
    static void Main()
    {
        float n1 = 10;
        int n2 = (int)n1; //operação de TypeCast  - converter um tipo em outro, quando não é implicito (segura e automatica pelo compilador)

        Console.WriteLine(n2);

        int vInt = 20;
        short vLong = (short)vInt;

        Console.WriteLine(vLong);

    }
}
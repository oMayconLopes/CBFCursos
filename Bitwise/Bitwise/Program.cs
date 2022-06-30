using System;
    class Bitwise
{
    static void Main()
    {
        int num1, num2;

        num1 = num2 = 100;

        Console.WriteLine("{0} e {1}", num1, num2);

        num1 =num1<< 1;
        num2 =num2>>1;

        Console.WriteLine("{0} e {1}", num1, num2);

        num1 = num2 = 100;

        num1 = num1 << 2;
        num2 = num2 >> 2;

        Console.WriteLine("{0} e {1}", num1, num2);
    }
}
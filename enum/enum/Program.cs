using System;
class eEnum
{
    enum DiasSemana {Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado }; //valores possiveis para este tipo

    static void Main()
    {
        DiasSemana ds = DiasSemana.Domingo;

        Console.WriteLine(ds);

        DiasSemana dss = (DiasSemana)3; //Fazendo cast

        Console.WriteLine(dss);

        int dsss = (int)DiasSemana.Sexta;

        Console.WriteLine(dsss);
    }
}
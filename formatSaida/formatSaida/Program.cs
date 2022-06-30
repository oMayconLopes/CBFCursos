using System;
class formatSaida
{
    static void Main()
    {
        double valorCompra = 5.5;
        double valorVenda;
        double lucro = 0.1; //porcentagem de Lucro sobre o produto
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto ........: {0,15}", produto); // ...,15 se deve ao espaçamento da variavel
        Console.WriteLine("Valor compra....: {0,15:c}", valorCompra ); // ...:C se deve a formatação de saida valor monetário
        Console.WriteLine("Lucro...........: {0,15:p}", lucro); // ....:p se deve a formatação de saida para percentual
        Console.WriteLine("Valor de Venda..: {0,15:c}", valorVenda);

    }
}
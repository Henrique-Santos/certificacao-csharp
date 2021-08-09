using System;

namespace certificacao_csharp_roteiro
{
    class Decimal : IAulaItem
    {
        public void Executar()
        {
            double valorProduto1 = 10;
            double valorProduto2 = 20;
            double subTotal = 30;

            Console.WriteLine("Descobrindo se 10 + 20 == 30");
            Console.WriteLine((valorProduto1 + valorProduto2) == subTotal); // true

            double valorProduto3 = 10.10;
            double valorProduto4 = 20.20;
            double subTotal2 = 30.30;

            Console.WriteLine("Descobrindo se 10.10 + 20.20 == 30.30");
            Console.WriteLine((valorProduto3 + valorProduto4) == subTotal2); // false
            /*
            Esses tipos armazenam números como representação binária. Para alcançar uma representação
            decimal, por exemplo "30.30", é necessário um arredondamento.
            */

            Console.WriteLine(valorProduto3 + valorProduto4); // 30.30
            /*
            Quando convertemos esse número para um formato de impressão, ele será arredondado, mas 
            internamente, o valor não será exatamente "30.30". Por isso devemos tomar esse cuidado 
            ao trabalhar com números de ponto flutuante. 
            */

            Console.WriteLine("Descobrindo se (10.1 + 20.2) == 30.299999999999997");
            Console.WriteLine((valorProduto3 + valorProduto4) == 30.299999999999997);

            decimal materiaPrima = 10.1m; // System.Decimal
            decimal maoDeObra = 20.2m;
            decimal custo = 30.3m;

            Console.WriteLine("Descobrindo se (10.1m + 20.2m) == 30.3m");
            Console.WriteLine((materiaPrima + maoDeObra) == custo);
            /*
            O decimal é outro tipo de ponto flutuante, mas internamente é representado como um 
            número decimal, não um binário 
            */
        }
    }
}

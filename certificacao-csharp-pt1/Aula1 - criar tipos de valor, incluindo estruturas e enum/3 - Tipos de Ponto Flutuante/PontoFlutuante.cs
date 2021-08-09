using System;
namespace certificacao_csharp_roteiro
{
    class PontoFlutuante : IAulaItem
    {
        public void Executar()
        {
            float idade = 15.5f; // System.Single

            Console.WriteLine($"long.MinValue: {long.MinValue}");
            Console.WriteLine($"long.MaxValue: {long.MaxValue}");

            float massaDaTerra = 5.6736e24f; // Equivale a: 5.6736 x 10^24

            float numeroPI = 3.14159f;

            Console.WriteLine($"massaDaTerra: {massaDaTerra}");
            Console.WriteLine($"numeroPI: {numeroPI}");

            double numeroMuitoMaior = 6e100; // System.Double

            Console.WriteLine("Operação com int, float e short");

            int x = 3;
            short y = 5;

            var resultado1 = x * y;
            Console.WriteLine($"x * y = {resultado1}");
            Console.WriteLine($"O resultado é do tipo: {resultado1.GetType()}"); // Adere o tipo que tem a maior capacidade.

            float z = 4.5f;

            var resultado2 = (x * y) / z;
            Console.WriteLine($"(x * y) / z = {resultado2}");
            Console.WriteLine($"O resultado é do tipo: {resultado2.GetType()}");
        }
    }
}

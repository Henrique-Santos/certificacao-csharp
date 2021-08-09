using System;

namespace certificacao_csharp_roteiro
{
    class Delegates : IAulaItem
    {
        public void Executar()
        {
            Calculadora.Executar();
        }
    }

    // Criando um delegate, que tem como assinatura, um parametro do tipo double e um retorno do tipo double
    delegate double MetodoMultiplicacao (double input);

    class Calculadora
    {
        static double Duplicar(double input)
        {
            return input * 2;
        }

        static double Triplicar(double input)
        {
            return input * 3;
        }

        public static void Executar()
        {

            //Executa diretamente o método
            Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");

            //Executa diretamente o método
            Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");

            // Usando o delegate
            MetodoMultiplicacao multiplicar = Duplicar;
            Console.WriteLine(multiplicar(7.5));

            multiplicar = Triplicar;
            Console.WriteLine(multiplicar(7.5));

            // Criando um delegate anonimo
            MetodoMultiplicacao metodoQuadrado = delegate (double input) {
                return input * input;
            };

            double quadrado = metodoQuadrado(5);
            Console.WriteLine(quadrado);

            // Criando um delegte usando lambda
            MetodoMultiplicacao metodoCubo = input => input * input * input;
            double cubo = metodoCubo(4.5);
            Console.WriteLine(cubo);
        }
    }
}

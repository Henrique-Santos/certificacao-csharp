﻿using System;

namespace certificacao_csharp_roteiro
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            //VOLUME DO CUBO = lado ^ 3;
            int lado = 3;
            Console.WriteLine("Volume do Cubo: " + Volume(lado));

            //VOLUME DO CILINDRO = altura * PI * raio ^ 2;
            double raio = 2;
            int altura = 10;
            Console.WriteLine("Volume do Cilindro: " + Volume(altura, raio));

            //VOLUME DO PRISMA = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;
            Console.WriteLine("Volume do Prisma: " + Volume(largura, profundidade, altura));
        }

        /*
        A sobrecarga permite que utilizemos o mesmo nome de método desde que a assinatura, ou seja, 
        a lista de parâmetros varie, ou pelo nome ou pelo tipo de parâmetro.
        */

        double Volume(double lado)
        {
            return Math.Pow(lado, 3);
        }

        double Volume(double altura, double raio)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }

        double Volume(double largura, double profundidade, double altura)
        {
            return largura * profundidade * altura;
        }
    }
}

using System;

namespace certificacao_csharp_roteiro
{
    class Estruturas : IAulaItem
    {
        public void Executar()
        {
            double Latitude1 = 13.78;
            double Longitude1 = 29.51;
            double Latitude2 = 40.23;
            double Longitude2 = 17.4;
            Console.WriteLine($"Latitude1 = {Latitude1}");
            Console.WriteLine($"Longitude1 = {Longitude1}");
            Console.WriteLine($"Latitude2 = {Latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");

            /*
             Quando criamos uma nova variável do tipo struct, automaticamente é chamado um construtor 
            dessa estrutura interna e todos os campos dessa estrutura são inicializados com um valor default.
             */
            PosicaoGPS posicao1;
            posicao1.Latitude = 13.78;
            posicao1.Longitude = 29.51;

            /*
             O operador new instancia o struct, e entre chaves colocaremos a inicialização do 
            momento de criação dessa variável.
             */
            posicao1 = new PosicaoGPS() { Latitude = 13.78, Longitude = 29.51 };

            /*
             Com o método construtor, no momento em que usamos o operador new já podemos passar 
            os parâmetros iniciais da estrutura dentro dos parênteses.
             */
            posicao1 = new PosicaoGPS(13.78, 29.51);

            Console.WriteLine(posicao1);
        }
    }

    // O struct não pode ter um construtor explícitos que não possuem parâmetros.
    struct PosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public PosicaoGPS(double latitude, double longitude) {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool EstaNoHemisferioNorte() {
            return Latitude > 0;
        }

        public override string ToString() {
            return $"Latitude: {Latitude}, Longitude: {Longitude}";
        }
    }

    /*
    Outra característica importante de uma struct, que a diferencia de uma classe, é que uma variável 
    que é uma estrutura é um tipo de valor, e não um tipo de referência. Isso significa que quando 
    copiamos uma estrutura para outra, ambas as variáveis ficam independentes.
    Se alterarmos o valor de uma estrutura, essa modificação não refletirá no valor da outra, 
    diferentemente do que acontece com as classes. Além disso uma estrutura costuma ser usada para 
    representar o que seria uma classe muito simples.
     */

    interface IGPS 
    {
        bool EstaNoHemisferioNorte();
    }

}

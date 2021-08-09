using System;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            char resposta = 'S';// System.Char
            byte nivelDeAzul = 0xF; // = 255 em decimal
            short passageirosVoo = 230; // System.Int16
            int populacao = 1500; // SystemInt.3
            long populacaoDoBrasil = 207_660_929; // +/- 207 milhões - System.Int64

            sbyte niveldeBrilho = -127; //System.SByte
            ushort passageirosNavio = 230; // System.UInt16
            uint estoque = 1500; // System.UInt32
            ulong populacaoDoMundo = 7_000_000_000; //7 bilhões = System.UInt64

            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"resposta: {resposta}");
            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");

            Console.WriteLine($"niveldeBrilho: {niveldeBrilho}");
            Console.WriteLine($"niveldeBrilho: {passageirosNavio}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");
        }
    }
}

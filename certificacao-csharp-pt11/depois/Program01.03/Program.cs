﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Program01._03
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tarefa 1: Processar uma faixa de 100 itens em paralelo
            var resultadoLoop =  
                Parallel.For(0, 99, (int i, ParallelLoopState state) => 
                {
                    //Tarefa 3: Interromper quando começar a processar o valor 75
                    if (i == 75) state.Break(); // Interrompendo a execucao do loop
                    Processar(i);
                });
            //Tarefa 2: Completou sem interrupção?
            Console.WriteLine("Completou sem interrupção? {0}", resultadoLoop.IsCompleted);
            //Tarefa 4: Quantos itens foram processados (parcialmente)?
            Console.WriteLine("Quantos itens foram processados (parcialmente)? {0}", resultadoLoop.LowestBreakIteration);

            Console.WriteLine("Término do processamento. Tecle [ENTER] para terminar.");
            Console.ReadLine();
        }

        static void Processar(object item)
        {
            Console.WriteLine("Começando a trabalhar com: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Terminando a trabalhar com: " + item);
        }
    }
}



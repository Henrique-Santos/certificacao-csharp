﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Program01
{
    //Task Parallel com Parallel.For / PLINQ / Tasks
    class Program
    {
        static void Main(string[] args)
        {

            //TAREFA 1: Cozinhar e refogar EM SÉRIE
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            CozinharMacarrao();
            RefogarMolho();
            stopwatch.Stop();
            Console.WriteLine("Tempo decorrido: {0} segundos", stopwatch.ElapsedMilliseconds / 1000.0);

            //TAREFA 2: Cozinhar e refogar EM PARALELO
            stopwatch.Restart();
            Parallel.Invoke(() => CozinharMacarrao(), () => RefogarMolho()); // Executa os métodos em paralelo
            stopwatch.Stop();

            //TAREFA 3: Medir o tempo dos 2 procedimentos
            Console.WriteLine("Tempo decorrido: {0} segundos", stopwatch.ElapsedMilliseconds / 1000.0);

            Console.WriteLine(
                "Retire do fogo e ponha o molho sobre o macarrão. " +
                "Bom apetite! " +
                "Tecle [ENTER] para terminar.");
            Console.ReadLine();
        }

        static void CozinharMacarrao()
        {
            Console.WriteLine("Cozinhando macarrão...");
            Thread.Sleep(1000);
            Console.WriteLine("Macarrão já está cozido!");
            Console.WriteLine();
        }

        static void RefogarMolho()
        {
            Console.WriteLine("Refogando molho...");
            Thread.Sleep(2000);
            Console.WriteLine("Molho já está refogado!");
            Console.WriteLine();
        }
    }
}

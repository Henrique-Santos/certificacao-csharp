﻿//#define RELATORIO_DETALHADO
#define RELATORIO_RESUMIDO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Programa03
{
    //Usar reflection
    class Program
    {
        static void Main(string[] args)
        {
            Relatorio relatorio = new Relatorio("Relatório de Vendas");
            relatorio.Imprimir();

            Console.WriteLine();
            if (Attribute.IsDefined(typeof(Venda), typeof(SerializableAttribute)))
            {
                Console.WriteLine("A classe Venda DEFINE o atributo Serializable");
            }
            else
            {
                Console.WriteLine("A classe Venda NÃO DEFINE o atributo Serializable");
            }
            Console.WriteLine();

            //TAREFA 1: 
            Console.WriteLine("OBTENDO O TIPO DO RELATÓRIO");
            Console.WriteLine("===========================");

            Type tipo = relatorio.GetType();
            Console.WriteLine(tipo);

            //TAREFA 2: 
            Console.WriteLine();
            Console.WriteLine("OBTENDO OS MEMBROS DO RELATÓRIO");
            Console.WriteLine("===============================");

            // Os campos, as propriedades, os construtores são listados como Membros de um Tipo    
            MemberInfo[] membros = tipo.GetMembers();
            foreach (var membro in membros)
            {
                Console.WriteLine(membro.ToString());
            }
            
            //TAREFA 3: 
            Console.WriteLine();
            Console.WriteLine("MODIFICANDO NOME VIA REFLECTION");
            Console.WriteLine("===============================");

            relatorio.Nome = "NOME MODIFICADO!";
            relatorio.Imprimir();

            // Para alterar a Propriedade Nome por meio de Reflection é necessario saber qual Membro tem essa função. (set_Nome)
            MethodInfo methodInfo = tipo.GetMethod("set_Nome");
            // O primeiro parametro é o objeto alvo, e dps o array de objetos que possui o novo valor
            methodInfo.Invoke(relatorio, new object[] { "NOME MODIFICADO VIA REFLECTION!" });
            relatorio.Imprimir();

            //TAREFA 4: 
            Console.WriteLine();
            Console.WriteLine("TIPOS DO ASSEMBLY");
            Console.WriteLine("QUE IMPLEMENTAM A INTERFACE IRelatorio");
            Console.WriteLine("======================================");

            Assembly esteAssembly = Assembly.GetExecutingAssembly();
            var tipos = esteAssembly.GetTypes(); // Retorna todas as classes/interfaces do Projeto
            foreach (var tipoAssembly in tipos)
            {
                if (tipoAssembly.IsInterface)
                {
                    continue;
                }

                if (typeof(IRelatorio).IsAssignableFrom(tipoAssembly)) // Verifica se o assembly implementa a Interface IRelatorio
                {
                    Console.WriteLine(tipoAssembly);
                }
            }


            //TAREFA 5: 
            Console.WriteLine();
            Console.WriteLine("USANDO LINQ PARA VER TIPOS DO ASSEMBLY");
            Console.WriteLine("QUE IMPLEMENTAM A INTERFACE IRelatorio");
            Console.WriteLine("======================================");

            var consulta = from t in tipos
                           where typeof(IRelatorio).IsAssignableFrom(t)
                            && !t.IsInterface
                           select t;

            foreach (var tipoConsulta in consulta)
            {
                Console.WriteLine(tipoConsulta.ToString());
            }

            Console.ReadLine();
        }
    }
}

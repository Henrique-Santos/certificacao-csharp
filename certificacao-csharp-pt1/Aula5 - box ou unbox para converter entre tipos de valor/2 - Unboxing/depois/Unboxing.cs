using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    // Unboxing sempre trabalha com COPIAS de valores
    class Unboxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57; // tipo de valor
            object caixa = numero; // boxing -> Armazenar um valor primitivo dentro de um objeto

            ///<image url="$(ProjectDir)img10.png" />

            try
            {
                int unboxed = (int)caixa; // Fazendo unboxing
                //int unboxed = (short)caixa; // Gera erro de conversao
                //short unboxed = (short)(int)caixa; // Converte com sucesso
                Console.WriteLine("Unboxing OK.");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("{0} Erro: unboxing incorreto.", e.Message);
            }
        }
    }
}

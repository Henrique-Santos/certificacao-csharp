using System;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade; // Declaração da variavel
            idade = 30; // Atribuindo valor a variavel
            Console.WriteLine(idade);
            System.Int32 idade2 = 18; // Outra maneira de especificar o tipo de uma variavel que armazena um int

            int copiaIdade = idade;
            Console.WriteLine(idade);
            Console.WriteLine(copiaIdade);

            idade = 23;
            Console.WriteLine(idade);
            Console.WriteLine(copiaIdade);

            int? idade3 = null; // Delarando e atribuindo uma variavel que pode ser anulavel, ou seja ter um valor nulo
            System.Nullable<int> idade4 = null; // Outra maneira de especificar uma variavel que armazena tipos inteiros, e pode receber null

        }
    }
}

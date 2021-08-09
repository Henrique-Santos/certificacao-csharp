using System;

namespace certificacao_csharp_roteiro
{
    class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {
            int idade = 42;
            int copiaIdade = idade; // Cópia por valor, a modificação da variavel original não afeta as usas cópias.

            Console.WriteLine("int idade = 42;");
            Console.WriteLine("int copiaIdade = idade;");
            Console.WriteLine($"idade: { idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            idade = 32;

            Console.WriteLine();
            Console.WriteLine("idade = 32;");
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            var cliente1 = new Cliente("José da Silva", 42);
            var cliente2 = cliente1; // Cópia por referencia, náo é feita um cópia independente, as duas variaveis apontam para o mesmo enderço na memória.
            Console.WriteLine();
            Console.WriteLine(@"var cliente1 = new Cliente(""José da Silva"";");
            Console.WriteLine("var cliente2 = cliente1;");
            Console.WriteLine($"cliente1: {cliente1}");
            Console.WriteLine($"cliente2: {cliente2}");

            cliente1.Nome = "Maria de Souza";

            Console.WriteLine();
            Console.WriteLine(@"cliente1.Nome = ""Maria de Souza"";");
            Console.WriteLine($"cliente1: {cliente1}");
            Console.WriteLine($"cliente2: {cliente2}");
        }
    }

    class Cliente 
    {
        public Cliente(string nome, int idade) 
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString() 
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
}

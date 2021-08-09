using System;

namespace certificacao_csharp_roteiro
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            ClienteEspecial clienteEspecial = new ClienteEspecial("Lucas Skywalker");
            clienteEspecial.FazerPedido(1, "Residencial", 1);

            clienteEspecial = new ClienteEspecial();
            clienteEspecial.FazerPedido(1, "Residencial", 1);
            clienteEspecial.FazerPedido(2, "Comercial");
            clienteEspecial.FazerPedido(3);
            clienteEspecial.FazerPedido(3, quantidade: 4);
        }
    }

    class ClienteEspecial
    {
        private readonly string nome;
        public ClienteEspecial(string nome = "Anonimo") // Definindo um valor opcional ao argumento, caso ele não seja passado.
        {
            this.nome = nome;
        }

        public void FazerPedido(int produtoId, string endereco = "Recidencial", int quantidade = 10)
        {
            Console.WriteLine("cliente {0}: produtoId: {1}, endereço: {2}, quantidade: {3}.", nome, produtoId, endereco, quantidade);
        }
    }
}

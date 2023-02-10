using System;
using System.Linq.Expressions;

namespace Programa04._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<float, float> metade = quo => quo / 2;
            Console.WriteLine("Metade de 9 é {0}", metade(9));

            //TAREFA: Recriar a Função acima, 
            //porém usando árvore de expressões LINQ

            //1) Criar as expressões individuais
            ParameterExpression quociente = Expression.Parameter(typeof(float), "quo"); // Criando o parametro da expresão
            ConstantExpression divisor = Expression.Constant(2f, typeof(float)); // O valor de divisão que é uma constante
            BinaryExpression opDivisao = Expression.Divide(quociente, divisor); // Utiliza o operador de divisão com uma expressão binaria

            //2) Criar a árvore de expressões
            Expression<Func<float, float>> exprMetade = Expression.Lambda<Func<float, float>>(opDivisao, new ParameterExpression[] { quociente }); // Cria a expresão lambda

            //3) Compilar e executar o código
            var metadeCompilada = exprMetade.Compile();
            Console.WriteLine("Metade de 7 é {0}", metadeCompilada(7));

            //4) Modificar a árvore de expressões
            TrocarDivisaoPorMultiplicacao troca = new TrocarDivisaoPorMultiplicacao();
            Expression<Func<float, float>> exprDobro = (Expression<Func<float, float>>)troca.Modificar(exprMetade);
            var dobroCompilado = exprDobro.Compile();
            Console.WriteLine("Dobro de 15 é {0}", dobroCompilado(15));

            Console.ReadLine();
        }
    }

    // Para alterar uma arvore de expresão é necessario implementar um ExpressionVisistor
    class TrocarDivisaoPorMultiplicacao : ExpressionVisitor
    {
        public Expression Modificar(Expression expression)
        {
            return Visit(expression);
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            // Aqui é verificado se o nó for um operador de dividir e troca por um de multiplicação
            if (node.NodeType == ExpressionType.Divide)
            {
                return Expression.Multiply(node.Left, node.Right);
            }
            return base.VisitBinary(node);
        }
    }
}
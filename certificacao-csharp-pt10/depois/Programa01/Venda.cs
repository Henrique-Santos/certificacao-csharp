using Newtonsoft.Json;
using System;

namespace Programa01
{
    [Serializable]
    //Definir na classe Venda os formatos de impressão detalhada e resumida
    [FormatoResumido("{0}  {1}  {2}  {3}")]
    [FormatoDetalhado("{0}  {1}  {2}  {3}  {4}  {5}  {6}  {7}")]
    public class Venda
    {
        public string Data;
        public string Produto;
        public int Preco;
        public string TipoPagamento;
        [NonSerialized] //Impede a serialização do campo Nome do comprador
        public string Nome;
        public string Cidade;
        public string Estado;
        public string Pais;
        public string DataCriacao;
        public string UltimoLogin;
        public double Latitude;
        public double Longitude;
    }

    // AttributeTargets.Class indica que esse atributo só será usado em Classes e não em Propriedades
    // AllowMultiple como false proibe o uso repetitivo do atribut FormatoResumido dentro da mesma Classe
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class FormatoResumidoAttribute : Attribute // Criando um Attributo Persolanizado
    {
        public string Formato { get; }

        public FormatoResumidoAttribute(string formato)
        {
            Formato = formato;
        }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class FormatoDetalhadoAttribute : Attribute
    {
        public string Formato { get; }

        public FormatoDetalhadoAttribute(string formato)
        {
            Formato = formato;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace _02_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml =
            "<Filmes>" +
                "<Filme>" +
                    "<Diretor>Quentin Tarantino</Diretor>" +
                    "<Titulo>Pulp Fiction</Titulo>" +
                    "<Minutos>154</Minutos>" +
                "</Filme>" +
                "<Filme>" +
                    "<Diretor>James Cameron</Diretor>" +
                    "<Titulo>Avatar</Titulo>" +
                    "<Minutos>162</Minutos>" +
                "</Filme>" +
            "</Filmes>";

            XDocument documento = XDocument.Parse(xml); // Classe adequada para acessar XML por meio do LINQ

            IEnumerable<XElement> consulta =
                from f in documento.Descendants("Filme")
                select f;

            foreach (var item in consulta)
            {
                Console.WriteLine(item.Element("Diretor").FirstNode); // Acessando o primeiro Nó do Elemento, ele possui o valor da chave no XML
                Console.WriteLine(item.Element("Titulo").FirstNode);
            }

            Console.WriteLine();

            IEnumerable<XElement> consulta2 =
            from f in documento.Descendants("Filme")
            where (string)f.Element("Diretor") == "James Cameron" // A conversão explicita ao Elemento, faz com que o acesso ao primeiro Nó não seja necessário para comparação
            select f;

            foreach (var item in consulta2)
            {
                Console.WriteLine((string)item.Element("Diretor"));
                Console.WriteLine((string)item.Element("Titulo"));
            }

            Console.WriteLine();

            IEnumerable<XElement> consulta3 =
            documento.Descendants("Filme")
            .Where(elemento => (string)elemento.Element("Diretor") == "James Cameron");

            foreach (var item in consulta3)
            {
                Console.WriteLine((string)item.Element("Diretor"));
                Console.WriteLine((string)item.Element("Titulo"));
            }

            Console.WriteLine();

            XElement pulpFiction = consulta.FirstOrDefault(x => (string)x.Element("Titulo") == "Pulp Fiction");

            pulpFiction?.Add(new XElement("Genero", "Drama")); // Modificando o XML por adicionar uma tag chamada Genero com o valor Drama

            XElement avatar = consulta.FirstOrDefault(x => (string)x.Element("Titulo") == "Avatar");

            avatar.Add("Genero", "Ficção Cientifica");

            foreach (var item in consulta)
            {
                Console.WriteLine((string)item.Element("Diretor"));
                Console.WriteLine((string)item.Element("Titulo"));
                Console.WriteLine((string)item.Element("Genero"));
            }

            Console.ReadKey();
        }
    }
}

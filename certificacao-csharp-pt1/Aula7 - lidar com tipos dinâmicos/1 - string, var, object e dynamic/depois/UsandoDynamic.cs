using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            //tipo é definido na compilação
            string s = "Certificação C#";
            //tipo é definido na compilação (por inferência)
            var v = "Certificação C#";
            //tipo é definido na compilação
            object o = "Certificação C#";

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper(); // Necessario casting para o uso do metodo ToUpper

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            //s = 123; // Não funciona
            //v = 123; // Não funciona
            o = 123;

            o = (int)o + 4;

            Console.WriteLine(o);

            // não é necessario casting com dynamic
            //tipo é definido somente na execução
            dynamic d = "Certificação C#";
            Console.WriteLine(d);
            d = d.ToUpper();
            Console.WriteLine(d);
            d = 123;
            Console.WriteLine(d);
            d = d + 4;
            Console.WriteLine(d);
        }
    }
}

using System;

namespace certificacao_csharp_roteiro
{
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            object objeto = 1;
            //objeto += 3; Não deixa executar
            /*
            Isso acontece porque o dynamic tem um funcionamento diferente do object durante o tempo de 
            compilação. Mas depois que compilamos, ele se comporta exatamente como um objeto.
            */

            dynamic dinamico = 1;
            dinamico += 3;

            Console.WriteLine(dinamico);
        }
    }
}

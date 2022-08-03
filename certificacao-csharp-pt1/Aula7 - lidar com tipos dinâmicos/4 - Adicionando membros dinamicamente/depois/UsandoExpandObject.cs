using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class UsandoExpandObject : IAulaItem
    {
        public void Executar()
        {
            string json = "{\"De\": \"Paulo Silveira\"," +
                "\"Para\": \"Guilherme Silveira\"}";

            // Podemos adicionar métodos e propriedades dinamicamente em um objeto ExpandoObject
            dynamic mensagem = JsonConvert.DeserializeObject<ExpandoObject>(json);

            mensagem.Texto = "Olá, " + mensagem.Para; // Criando uma propriedade dinamicamente

            EnviarMensagem(mensagem);

            // Adicionando um método ao objeto dinamico
            mensagem.Inverter = new Action(() =>
            {
                var aux = mensagem.De;
                mensagem.De = mensagem.Para;
                mensagem.Para = aux;
                mensagem.Texto = "Olá, " + mensagem.Para;
            });

            mensagem.Inverter();
            EnviarMensagem(mensagem);
        }

        private void EnviarMensagem(dynamic msg)
        {
            Console.WriteLine($"De: {msg.De}");
            Console.WriteLine($"Para: {msg.Para}");
            Console.WriteLine($"Texto: {msg.Texto}");
            Console.WriteLine();
        }
    }
}

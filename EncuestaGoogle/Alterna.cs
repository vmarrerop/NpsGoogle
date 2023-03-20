using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncuestaGoogle
{
    internal class Alterna
    {
        /*
        static async Task Main()
        {
            // Construir la URL de la solicitud
            var url = "https://language.googleapis.com/v1/documents:analyzeEntitySentiment";

            // Agregar el token de acceso
            var token = "AIzaSyAAldH3Yq4U2CVA-0HkUoFYmnTZTDtcoh4";

            // Crear el cliente HttpClient
            var client = new HttpClient();

            // Agregar el encabezado Authorization
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            // Crear el cuerpo de la solicitud en formato JSON
            var requestContent = new
            {
                document = new
                {
                    type = "PLAIN_TEXT",
                    content = "I love R&B music. Marvin Gaye is the best. 'What's Going On' is one of my favorite songs. It was so sad when Marvin Gaye died."
                },
                encodingType = "UTF8"
            };
            var json = JsonConvert.SerializeObject(requestContent);
            var requestBody = new StringContent(json, Encoding.UTF8, "application/json");

            // Realizar la solicitud HTTP POST
            var response = await client.PostAsync(url, requestBody);

            // Leer la respuesta de la solicitud
            var responseContent = await response.Content.ReadAsStringAsync();

            // Mostrar la respuesta en la consola
            Console.WriteLine(responseContent);
        }

        */
    }
}

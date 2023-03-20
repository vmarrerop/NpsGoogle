using System;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp
{
    class Program
    {
     
        static async Task Main()
{
    // Construir la URL de la solicitud
    var url = "https://language.googleapis.com/v1/documents:analyzeEntitySentiment";

    // Agregar la clave de API
    var apiKey = "AIzaSyCVlL4qu69wBGg2kgd2cRo8AMejT5ECuMg";

    // Crear el cliente HttpClient
    var client = new HttpClient();

    // Agragando la clave Api a la URL
    url += $"?key=AIzaSyCVlL4qu69wBGg2kgd2cRo8AMejT5ECuMg";

    // Creacion del cuerpo de la solicitud en formato JSON
    var requestContent = new
    {
        document = new
        {
            type = "PLAIN_TEXT",
            content = "Me encanto el servicio de telemedicina."
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
    }
}



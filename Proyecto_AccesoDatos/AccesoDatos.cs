using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Proyecto_AccesoDatos
{
    public class AccesoDatos
    {
        private string loginURL = "http://localhost:8080/";
        public AccesoDatos()
        {

        }
        public async Task<string> enviarPeticionLogin(string pet, string user, string pass, string token)
        {
            try
            {
                var peticionActual = new Peticion
                {
                    peticion = pet,
                    usuario = user,
                    clave = pass,
                    token = token
                };
                // Serializa nuestra clase en una cadena JSON
                var stringPeticion = await Task.Run(() => JsonConvert.SerializeObject(peticionActual));
                // Envuelve nuestro JSON dentro de un StringContent que luego puede ser usado por la clase HttpClient
                var httpContent = new StringContent(stringPeticion, Encoding.UTF8, "application/json");

                using (var httpClient = new HttpClient())
                {
                    // Ejecuta la solicitud actual y espera la respuesta
                    var httpResponse = await httpClient.PostAsync(loginURL, httpContent);
                    if (httpResponse.Content != null)
                    {
                        var responseContent = await httpResponse.Content.ReadAsStringAsync();                        
                        var objetoJSON = JObject.Parse(responseContent);
                        Respuesta respuesta = objetoJSON.ToObject<Respuesta>();
                        if (pet.Equals("requestSalt"))
                        {
                            return respuesta.salt;
                        } else if (pet.Equals("login"))
                        {
                            return respuesta.token;
                        }

                    }
                    else
                    {
                        return null; //TODO añadir un mensaje o algo
                    }
                    return null; //TODO añadir un mensaje o algo
                }
            }
            catch (Exception e)
            {
                return null; //TODO añadir una excepcion decente con un mensaje o algo
            }
        }
        
    }
}
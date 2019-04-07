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
        private static string token = "";
        public AccesoDatos()
        {

        }
        public async Task<string> comenzarLogin(string usuario, string clave)
        {
            //Peticion para que nos devuelva una respuesta con la sal que necesitamos
            Respuesta respConSal = await this.enviarPeticion("requestSalt", usuario, null, null);
            //Si al hacer la peticion el servidor esta caido devuelve un null
            if (respConSal != null)
            {
                if (respConSal.respuesta.Equals("noExisteUsuario"))
                {
                    return "Usuario no registrado";

                }
                else // if(respActual.respuesta.Equals("usuarioEncontrado"))
                {
                    // Encripta clave con la "sal" recibida
                    string PassEncriptado = Clave.encriptarClaveConexion(clave, respConSal.salt);
                    // Petición enviando clave encriptada si es correcta nos devolvera el "Token"
                    Respuesta respConToken = await this.enviarPeticion("login", usuario, PassEncriptado, null);
                    // Asignamos nuestro token
                    if (respConToken.respuesta.Equals("passValida"))
                    {
                        token = respConToken.token;
                        return "Acceso concedido";
                    } else
                    {
                        return "Contraseña no válida";
                    }
                    
                }
            }
            else
            {
                //Mensaje por si el servidor esta caido
                return "Servidor caido";
            }
        }
        public async Task<Respuesta> enviarPeticion(string pet, string user, string pass, string token)
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
                        //Retornamos el objeto respuesta con todos sus atributos
                        Respuesta respuesta = objetoJSON.ToObject<Respuesta>();
                        return respuesta;
                    }
                    else
                    {
                        return null;
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e);
                return null;
            }
        }
        public async Task<bool> borrarToken(string usuario)
        {
            Respuesta respuesta = await enviarPeticion("borrarToken", usuario, null, token);
            if (respuesta.respuesta.Equals("tokenBorrado"))
            {
                token = "";
                return true;
            }else
            {
                return false;
            }
            
        }

    }
}
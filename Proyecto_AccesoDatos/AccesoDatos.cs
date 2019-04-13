using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using EntidadesCompartidas;

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
            Respuesta respConSal = await this.enviarPeticion("requestSalt", usuario, null, null, null);
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
                    Respuesta respConToken = await this.enviarPeticion("login", usuario, PassEncriptado, null, null);
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
        public async Task<Respuesta> enviarPeticion(string pet, string user, string pass, string token, Dictionary<string, string> registro)
        {
            string passCifrado = null;
            string tokenCifrado = null;
            string usuarioCifrado = null;
            //try
            //{
                if (pass != null)
                {
                    passCifrado = CifradoJson.Cifrado(pass, pet);
                }
                if (token != null)
                {
                    tokenCifrado = CifradoJson.Cifrado(token, pet);
                }
                if (user != null)
                {
                usuarioCifrado = CifradoJson.Cifrado(user, pet);
                }                
                var peticionActual = new Peticion
                {
                    peticion = pet,
                    usuario = usuarioCifrado,
                    clave = passCifrado,
                    token = tokenCifrado,
                    datos = registro
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

                        if (respuesta.salt != null)
                        {
                            respuesta.salt = CifradoJson.Descifrado(respuesta.salt, respuesta.respuesta);
                        }
                        if (respuesta.token != null)
                        {
                            respuesta.token = CifradoJson.Descifrado(respuesta.token, respuesta.respuesta);
                        }                        
                        return respuesta;
                    }
                    else
                    {
                        return null;
                    }
                    
                }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception: {0}", e);
            //    return null;
            //}
        }
        public async Task<bool> borrarToken(string usuario)
        {
            if (token != "")
            {
                Respuesta respuesta = await enviarPeticion("borrarToken", usuario, null, token, null);
                if (respuesta.respuesta.Equals("tokenBorrado"))
                {
                    token = "";
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;     
        }
        public async Task<List<Enlaces>> obtenerEnlaces(string usuario)
        {
            if (token.Equals("")) { token = null; }
            Respuesta respuesta = await enviarPeticion("obtenerColeccionEnlaces", usuario, null, token, null);
            return respuesta.coleccion;
        }
        public async Task<string> enviarEmailparaRegistro(string usuario, string pass, Dictionary<string, string> datos)
        {
            Respuesta respuesta = await enviarPeticion("emailRegistro", usuario, pass, null, datos);
            if (respuesta.respuesta.Equals("emailConTokenEnviado"))
            {
                return respuesta.token;
            }
            else
            {
                return "emailNoEnviado";
            }
        }
        public async Task<bool> buscarEmailEnBD(string emailABuscar)
        {
            Dictionary<string, string> email = new Dictionary<string, string>();
            email.Add("email", emailABuscar);
            Respuesta respuesta = await enviarPeticion("buscaEmailenBD", null, null, null, email);
            if (respuesta.respuesta.Equals("duplicado"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> buscarUsuarioEnBD(string usuarioABuscar)
        {
            Respuesta respuesta = await enviarPeticion("buscaUsuarioenBD", usuarioABuscar, null, null, null);
            if (respuesta.respuesta.Equals("duplicado"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
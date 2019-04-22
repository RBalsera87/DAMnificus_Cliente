
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
        private string urlServidor = "http://localhost:8080/";
        private static string token = "";
        public AccesoDatos()
        {

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

            using (var httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(100) }) // Timeout es para el tiempo que se debe esperar a la respuesta
            {                                                                                 // Para debug poner 100 o mas, para release 15 o 20 como mucho
                // Ejecuta la solicitud actual y espera la respuesta
                try
                {
                    var httpResponse = await httpClient.PostAsync(urlServidor, httpContent);
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
                catch (Exception)
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
                    }
                    else
                    {
                        return "Contraseña no válida";
                    }

                }
            }
            else
            {
                //Mensaje por si el servidor esta caido ---------------------->esto hay que cambiarlo
                return "Servidor caido";
            }
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
            List<Enlaces> listaEnlaces = respuesta.coleccion.ToObject<List<Enlaces>>();
            return listaEnlaces;
        }
        public async Task<string> enviarEmailparaRegistro(string usuario, Dictionary<string, string> datos)
        {
            Respuesta respuesta = await enviarPeticion("emailRegistro", usuario, null, null, datos);
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
            if (respuesta.respuesta.Equals("duplicado")) // Hay que controlar el nullreference exception
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
            if (respuesta.respuesta.Equals("duplicado")) // Hay que controlar el nullreference exception
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> enviarConfirmacionRegistro(string usuario, string pass, Dictionary<string, string> datos)
        {
            // Se encripta la pass para guardarla en la BD
            string passEncriptada = Clave.encriptarClaveRegistro(pass);
            Respuesta respuesta = await enviarPeticion("confirmarRegistro", usuario, passEncriptada, null, datos);
            if (respuesta.respuesta.Equals("usuarioRegistrado"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<string> cambiarPass(string usuario, string passActual, string passNueva)
        {
            string passActualEncriptada = "";
            //Peticion para que nos devuelva una respuesta con la sal que necesitamos
            Respuesta respConSal = await this.enviarPeticion("requestSalt", usuario, null, null, null);
            //Si al hacer la peticion el servidor esta caido devuelve un null
            if (respConSal != null)
            {
                if (respConSal.respuesta.Equals("usuarioEncontrado"))
                {
                    // Encripta clave con la "sal" recibida
                    passActualEncriptada = Clave.encriptarClaveConexion(passActual, respConSal.salt);
                    // Se encripta la nueva pass para guardarla en la BD
                    string passNuevaEncriptada = Clave.encriptarClaveRegistro(passNueva);
                    // Se envia la petición con las dos pass encriptadas, por eso no hace falta token aquí
                    Respuesta respuesta = await enviarPeticion("cambiarPass", usuario, passActualEncriptada, passNuevaEncriptada, null);
                    return respuesta.respuesta;
                }
                else
                {
                    return "passNoCambiada";
                }
            }
            else
            {
                return "servidorOffline";
            }
            
        }
        public async Task<string> obtenerCurso(string usuario)
        {            
            Respuesta respuesta = await enviarPeticion("obtenerCurso", usuario, null, token, null);
            return respuesta.respuesta;
        }
        public async Task<bool> cambiarCurso(string usuario, string curso)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("curso", curso);
            Respuesta respuesta = await enviarPeticion("cambiarCurso", usuario, null, token, dic);
            if (respuesta.respuesta.Equals("cursoCambiado"))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public async Task<bool> enviarEmailReporte(string usuario, Dictionary<string, string> datos)
        {
            Respuesta respuesta = await enviarPeticion("emailReporte", usuario, null, token, datos);
            if (respuesta.respuesta.Equals("emailReporteEnviado"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<string> enviarEmailPassPerdida(string usuario, Dictionary<string, string> datos)
        {
            Respuesta respuesta = await enviarPeticion("emailPassPerdida", usuario, null, null, datos);
            if (respuesta.respuesta.Equals("emailConTokenEnviado"))
            {
                return respuesta.token;
            }
            else
            {
                return "emailNoEnviado";
            }
        }
        public async Task<bool> restaurarPass(string email, string passNueva)
        {
            string passNuevaEncriptada = "";
            passNuevaEncriptada = Clave.encriptarClaveRegistro(passNueva);
            Respuesta respuesta = await enviarPeticion("restaurarPass", email, passNuevaEncriptada, null, null);
            if (respuesta.respuesta.Equals("passCambiada"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public async Task<bool> pedirStatusServidor(string usuario)
        {

            Respuesta respuesta = await enviarPeticion("status", usuario, null, null, null);
            if (respuesta != null) // Hay que controlar el nullreference exception???
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
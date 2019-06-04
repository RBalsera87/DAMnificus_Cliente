
using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using EntidadesCompartidas;

namespace Proyecto_AccesoDatos
{

    /************************
     * CLASE ACCESO A DATOS *
     ************************/
    public class AccesoDatos
    {       
        private string urlServidor; 
        private static string token = "";

        /***************
         * Constructor *
         ***************/
        public AccesoDatos()
        {
            string ip = ConfigurationManager.AppSettings["serverIp"];
            urlServidor = "http://" + ip + ":8080/damnificus/";
        }

        // Método que se usa para codificar la petición y enviarla al servidor
        public async Task<Respuesta> enviarPeticion(string pet, string user, string pass, string token, Dictionary<string, string> registro)
        {
            string passCifrado = null;
            string tokenCifrado = null;
            string usuarioCifrado = null;

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
            {                                                                                 // Para debug poner 100 o mas, para release 5 o 10 como mucho
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

        }

        /**************************
         * Peticiones del cliente *
         **************************/

        // Este método se encarga de loguear al usuario en la app
        public async Task<string> comenzarLogin(string usuario, string clave)
        {
            //Peticion para que nos devuelva una respuesta con la sal que necesitamos
            Respuesta respConSal = await this.enviarPeticion("requestSalt", usuario, null, null, null);
            //Si al hacer la peticion el servidor esta caido devuelve un null
            if (respConSal != null)
            {
                if (respConSal.respuesta.Equals("noExisteUsuario"))
                {
                    return "El nombre de usuario no se encuentra en nuestra base de datos";

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
                    }else if (respConToken.respuesta.Equals("usuarioYaConectado"))
                    {
                        return "usuarioYaConectado";
                    }
                    else
                    {
                        return "La contraseña no parece válida";
                    }

                }
            }
            else
            {
                //Mensaje por si el servidor esta caido ---------------------->esto hay que cambiarlo
                return "El servidor no responde, revisa que tengas una conexión a internet";
            }
        }

        // Borra el token del usuario especificado
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

        // Obtiene una colección de los enlaces alojados del servidor
        public async Task<List<Enlaces>> obtenerEnlaces(string usuario, Dictionary<string,string> datos)
        {
            List<Enlaces> listaEnlaces = null;
            Respuesta respuesta = await enviarPeticion("obtenerColeccionEnlaces", usuario, null, token, datos);
            try
            {
                listaEnlaces = respuesta.coleccion.ToObject<List<Enlaces>>();
                return listaEnlaces;
            }
            catch (NullReferenceException)
            {
                return listaEnlaces;
            }
            
        }

        // Obtiene una colección de los usuarios registrados en el servidor
        public async Task<List<Usuario>> obtenerColeccionUsuarios(string usuario, Dictionary<string, string> datos)
        {
            List<Usuario> listaUsuarios = null;
            Respuesta respuesta = await enviarPeticion("obtenerColeccionUsuarios", usuario, null, token, datos);
            try
            {
                listaUsuarios = respuesta.coleccion.ToObject<List<Usuario>>();
                return listaUsuarios;
            }
            catch (NullReferenceException)
            {
                return listaUsuarios;
            }

        }

        public async Task<bool> borrarUsuario(string usuario, Dictionary<string, string> datos)
        {
            Respuesta respuesta = await enviarPeticion("borrarUsuario", usuario, null, token, datos);

            if (respuesta.respuesta.Equals("correcto"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> borrarEnlace(string usuario, Dictionary<string, string> datos)
        {
            Respuesta respuesta = await enviarPeticion("borrarEnlace", usuario, null, token, datos);

            if (respuesta.respuesta.Equals("correcto"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> cambiarRango(string usuario, Dictionary<string, string> datos)
        {
            Respuesta respuesta = await enviarPeticion("cambiarRango", usuario, null, token, datos);

            if (respuesta.respuesta.Equals("correcto"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<string>> sacarAsignaturas(string usuario, Dictionary<string, string> datos)
        {
            List<string> listaAsignaturas = null;
            Respuesta respuesta = await enviarPeticion("obtenerNombreAsignaturas", usuario, null, token, datos);
            try
            {
                listaAsignaturas = respuesta.coleccion.ToObject<List<string>>();
                return listaAsignaturas;
            }
            catch (NullReferenceException)
            {
                return listaAsignaturas;
                //¿Dar mensaje?
            }

        }
        public async Task<List<string>> obtenerNombreTemas(string usuario, Dictionary<string, string> datos)
        {
            List<string> listaTemas = null;
            Respuesta respuesta = await enviarPeticion("obtenerNombreTemas", usuario, null, token, datos);
            try
            {
                listaTemas = respuesta.coleccion.ToObject<List<string>>();
                return listaTemas;
            }
            catch (NullReferenceException)
            {
                return null;
            }

        }

        public async Task<string> sumaryRestarValoracion(string usuario,Dictionary<string, string> datos)
        {
            if(usuario.Equals("invitado")){
               
                return "invitado";
            }
            if (token.Equals("")) { token = null; }
            Respuesta respuesta = await enviarPeticion("sumarYRestarValoracion", usuario, null, token, datos);
            if (respuesta.respuesta.Equals("correcto"))
            {
                return "true";
            }else
            {
                return "false";
            }
           
        }
        public async Task<int> cambiarActivoRevisionDesactivo(string usuario, Dictionary<string, string> datos)
        {
            if (usuario.Equals("invitado"))
            {
                return -2;
            }
            if (token.Equals("")) { token = null; }
            Respuesta respuesta = await enviarPeticion("cambiarActivoRevisionDesactivo", usuario, null, token, datos);
            var estado = int.Parse(respuesta.respuesta);
            return estado;
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

        public async Task<List<double>> recogidaNotas(string usuario, Dictionary<string, string> datos)
        {
            List<Double> listaNotas = new List<double> { };
            Respuesta respuesta = await enviarPeticion("recogidaNotas", usuario, null, token, datos);
            try
            {
                listaNotas = respuesta.coleccion.ToObject<List<double>>();
                return listaNotas;
            }
            catch (NullReferenceException)
            {
                return listaNotas;
                //¿Dar mensaje?
            }
        }

        public async Task<List<double>> mediaNotas(string usuario, Dictionary<string, string> datos)
        {
            List<Double> listaNotas = new List<double> { };
            Respuesta respuesta = await enviarPeticion("mediaNotas", usuario, null, token, datos);
            try
            {
                listaNotas = respuesta.coleccion.ToObject<List<double>>();
                return listaNotas;
            }
            catch (NullReferenceException)
            {
                return listaNotas;
                //¿Dar mensaje?
            }
        }

        public async Task<int> sacarUsuario(string usuario, Dictionary<string,string>datos)
        {
            Respuesta respuesta = await enviarPeticion("sacarUsuario", usuario, null, token, datos);
            return Convert.ToInt32(respuesta.respuesta);
        }

        public async Task<bool> hayNota (string usuario, Dictionary<string,string>datos)
        {
            Respuesta respuesta = await enviarPeticion("hayNota", usuario, null, token, datos);
            if (respuesta.respuesta.Equals("si"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task agregarNota(string usuario, Dictionary<string, string> datos)
        {
            Respuesta respuesta = await enviarPeticion("agregarNota", usuario, null, token, datos);
            
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
        public async Task<bool> enviarNuevoEnlace(string usuario, Dictionary<string, string> datos)
        {
            Respuesta respuesta = await enviarPeticion("subirEnlace", usuario, null, token, datos);
            if (respuesta.respuesta.Equals("enlaceInsertado"))
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
        public async Task<string> obtenerCredenciales(string usuario)
        {
            if (usuario != "invitado")
            {
                Respuesta respuesta = await enviarPeticion("obtenerCredenciales", usuario, null, token, null);
                return respuesta.respuesta;
            }
            else
            {
                return "invitado";
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

        public async Task borrarNotas(string usuario, Dictionary<string,string>datos)
        {
            Respuesta respuesta = await enviarPeticion("borrarNotas", usuario, null, token, datos);
        }

        
    }
}
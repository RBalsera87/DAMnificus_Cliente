using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;

namespace Proyecto_AccesoDatos
{
    public class AccesoDatos
    {
        private string loginURL = "http://localhost:8080/";
        string token = "2JEuksuv86DcFmLrQa7nna4QDeowuGTqpyUK0pf9wSlbe6D5hLtEVxvzMT5gAZG0xBKy00HxS3J79mcr8F54dBD0uIg5HX5fzPOAP";
        string peticion;
        string nombreUsuario;
        string pass; // Cambiar a cifrado
        public AccesoDatos()
        {
            // Constructor vacio
        }

        public AccesoDatos(string token, string peticion, string nombreUsuario, string pass)
        {
            this.token = token;
            this.peticion = peticion;
            this.nombreUsuario = nombreUsuario;
            this.pass = pass;
        }

        public async Task<string> enviarPeticionLogin()
        {
            try
            {
                using (var Client = new HttpClient())
                {
                    Client.BaseAddress = new Uri(loginURL);
                    Client.DefaultRequestHeaders.Accept.Clear();
                    Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    // Crea la cadena de datos GET y los convierte en un array de bytes.
                    string postData =   "token=" + token +
                                        "&usuario=" + nombreUsuario +
                                        "&pass=" + pass;
                    HttpResponseMessage responce = await Client.GetAsync(postData);
                    if (responce.IsSuccessStatusCode)
                    {
                        var Json = await responce.Content.ReadAsStringAsync();

                        //  !
                        return Json;
                    }
                    else
                    {
                        // deal with error or here ...
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
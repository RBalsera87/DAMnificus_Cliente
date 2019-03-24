using Newtonsoft.Json;
using System.Net.Http;

namespace Proyecto_AccesoDatos
{
    public class Peticion
    {
        [JsonProperty("peticion")]
        public string peticion { get; set; }

        [JsonProperty("usuario")]
        public string usuario { get; set; }

        [JsonProperty("clave")]
        public string clave { get; set; }

        [JsonProperty("token")]
        public string token { get; set; }
    }
}

using Newtonsoft.Json;

namespace Proyecto_AccesoDatos
{
    class Respuesta
    {
        [JsonProperty("respuesta")]
        public string respuesta { get; set; }

        [JsonProperty("token")]
        public string token { get; set; }

        [JsonProperty("salt")]
        public string salt { get; set; }
    }
}


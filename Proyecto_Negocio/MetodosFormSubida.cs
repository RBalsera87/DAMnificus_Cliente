using Proyecto_AccesoDatos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proyecto_Negocio
{
    /***************************************************
     * Métodos para el Formulario de Subida de enlaces *
     ***************************************************/
    public class MetodosFormSubida
    {
        AccesoDatos ad = new AccesoDatos();
        public async Task<List<string>> obtenerAsignaturas(string usuario, int curso)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            datos.Add("curso", curso.ToString());
            return await ad.sacarAsignaturas(usuario, datos);
        }
        public async Task<List<string>> obtenerTemas(string usuario, string asignatura)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            datos.Add("asignatura", asignatura);
            return await ad.obtenerNombreTemas(usuario, datos);
        }
        public async Task<bool> enviarNuevoEnlace(string usuario, Dictionary<string, string> datos)
        {
            return await ad.enviarNuevoEnlace(usuario, datos);
        }

    }
}

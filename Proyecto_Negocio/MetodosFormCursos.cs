using EntidadesCompartidas;
using Proyecto_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proyecto_Negocio
{
    public class MetodosFormCursos
    {
        AccesoDatos ad = new AccesoDatos();
        public async Task<List<Enlaces>> obtenerEnlaces(string usuario, Dictionary<string, string> datos)
        {   
            return await ad.obtenerEnlaces(usuario,datos);
        }
        public async Task<string> sumarYRestarValoracion(string usuario, Dictionary<string, string> datos)
        {   
            return await ad.sumaryRestarValoracion(usuario, datos);
        }
        public async Task<string> cambiarActivoRevisionDesactivo(string usuario, Dictionary<string, string> datos)
        {
            return await ad.cambiarActivoRevisionDesactivo(usuario, datos);
        }
    }
}

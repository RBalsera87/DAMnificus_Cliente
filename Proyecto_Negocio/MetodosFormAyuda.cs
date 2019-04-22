using Proyecto_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Negocio
{
    /****************************************
     * Métodos para el Formulario de Ayuda  *
     ****************************************/
    public class MetodosFormAyuda
    {
        AccesoDatos ad = new AccesoDatos();
        public async Task<string> cambiarPass(string usuario, string passActual, string passNueva)
        {
            return await ad.cambiarPass(usuario, passActual, passNueva);
        }
        public async Task<string> obtenerCurso(string usuario)
        {
            return await ad.obtenerCurso(usuario);
        }
    }
}

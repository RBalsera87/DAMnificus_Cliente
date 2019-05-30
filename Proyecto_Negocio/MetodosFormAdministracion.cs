using Proyecto_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Proyecto_Negocio
{
    public class MetodosFormAdministracion
    {
        AccesoDatos ad = new AccesoDatos();
        public async Task<bool> borrarEnlace(string usuario, Dictionary<string, string> datos)
        {
            return await ad.borrarEnlace(usuario, datos);
        }
        public async Task<List<Usuario>> obtenerUsuarios(string usuario, Dictionary<string, string> datos)
        {   
            return await ad.obtenerColeccionUsuarios(usuario,datos);
        }
        public async Task<bool> borrarUsuario(string usuario, Dictionary<string, string> datos)
        {
            return await ad.borrarUsuario(usuario, datos);
        }
        public async Task<bool> cambiarRango(string usuario, Dictionary<string, string> datos)
        {
            return await ad.cambiarRango(usuario, datos);
        }
    }
}
